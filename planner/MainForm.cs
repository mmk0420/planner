using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Tulpep.NotificationWindow;

namespace planner
{
    public partial class MainForm : Form
    {
        BindingList<PlannerTask> tasks = new BindingList<PlannerTask>();
        Timer timer;
        DateTime now;
        int hoveredRow = -1;
        int hoveredColumn = -1;
        DgvHoverForm taskInfoHover = new DgvHoverForm();

        [JsonIgnore]
        public static Image popIMG { get; private set; } = Properties.Resources.iconPNG;

        public MainForm()
        {
            InitializeComponent();
            LoadData();

            this.Icon = Properties.Resources.icon;

            dgvTask.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvTask.DefaultCellStyle.ForeColor = Color.White; 
            dgvTask.DataSource = tasks;

            DoubleBuffered = true;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();

            dgvTask.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTask.GridColor = dgvTask.BackgroundColor;
            dgvTask.CellMouseDown += dgvTask_CellMouseDown;
            dgvTask.CellMouseEnter += DgvTask_CellMouseEnter;
            dgvTask.CellMouseLeave += DgvTask_CellMouseLeave;

        }

        private void SortTasks()
        {
            var sortedList = tasks.OrderBy(t =>
            {
                if (t.Status == 1) return -1; 
                return t.Status;              
            })
            .ThenBy(t => t.Deadline)
            .ToList();

            tasks.Clear();
            foreach (var task in sortedList)
            {
                tasks.Add(task);
            }
        }
        private void SaveData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText("tasks.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
        private void LoadData()
        {
            if (File.Exists("tasks.json"))
            {
                try
                {
                    string json = File.ReadAllText("tasks.json");
                    var loadedTasks = JsonConvert.DeserializeObject<List<PlannerTask>>(json);

                    tasks.Clear();
                    foreach (var task in loadedTasks)
                    {
                        tasks.Add(task);
                    }
                    SortTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки: " + ex.Message);
                }
            }
        }
        private void DgvTask_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            hoveredRow = e.RowIndex;
            hoveredColumn = e.ColumnIndex;

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as PlannerTask;
            if (task != null)
            {
                taskInfoHover.UpdateData(task);
                taskInfoHover.Show();
            }
        }

        private void DgvTask_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            hoveredRow = -1;
            hoveredColumn = -1;
            taskInfoHover.Hide();
        }


        private void dgvTask_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && hoveredRow >= 0 && hoveredColumn >= 0)
            {
                dgvTask.Rows[hoveredRow].Selected = true;
                taskInfoHover.Hide();
            }
            if (e.Button == MouseButtons.Left && hoveredRow >= 0 && hoveredColumn >= 0)
            {
                PlannerTask task = tasks[hoveredRow];
                switch (task.Status)
                {
                    case 0:
                        task.Status = 1;
                        break;
                    case 1:
                        task.Status = 2;
                        break;
                    default:
                        return;
                }
                taskInfoHover.UpdateData(task);
                SortTasks();
                SaveData();
                dgvTask.Invalidate();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            foreach (PlannerTask task in tasks.ToList())
            {

                task.left = task.Deadline - now;
                double totalMinutesLeft = task.left.TotalMinutes;
                string statusPrefix = "";

                if (task.Status == 0)
                {
                    statusPrefix = " Начните её!";
                }
                int totalHours = (int)task.left.TotalHours;

                if (task.Notification == -1225)
                {
                    if (totalMinutesLeft <= 5) task.Notification = -1;
                    else if (totalMinutesLeft <= 30) task.Notification = 2;
                    else if (totalMinutesLeft <= 60) task.Notification = 1;
                    else task.Notification = 0;
                }
                else
                {
                    if (totalMinutesLeft <= 5 && task.Notification != -1)
                    {
                        if (task.Name.Length > 15) task.popupStr = $"До дедлайна одной из задач осталось меньше 5 минут!{statusPrefix}";
                        else task.popupStr = $"До дедлайна задачи \"{task.Name}\" осталось меньше 5 минут!{statusPrefix}";
                        task.popup.ContentText = task.popupStr;
                        task.Notification = -1;
                        task.popup.Popup();
                    }
                    else if (totalMinutesLeft <= 30 && totalMinutesLeft > 5 && task.Notification < 2 && task.Notification >= 0)
                    {
                        if (task.Name.Length > 15) task.popupStr = $"До дедлайна одной из задач осталось меньше 30 минут!{statusPrefix}";
                        else task.popupStr = $"До дедлайна задачи \"{task.Name}\" осталось меньше 30 минут!{statusPrefix}";
                        task.popup.ContentText = task.popupStr;
                        task.Notification = 2;
                        task.popup.Popup();
                    }
                    else if (totalMinutesLeft <= 60 && totalMinutesLeft > 30 && task.Notification < 1 && task.Notification >= 0)
                    {
                        if (task.Name.Length > 15) task.popupStr = $"До дедлайна одной из задач осталось меньше часа!{statusPrefix}";
                        else task.popupStr = $"До дедлайна задачи \"{task.Name}\" осталось меньше часа!{statusPrefix}";
                        task.popup.ContentText = task.popupStr;
                        task.Notification = 1;
                        task.popup.Popup();
                    }
                }

                if (!task.isOverdue && now > task.Deadline && task.Status != 2)
                {
                    task.isOverdue = true;
                    task.Status = 3;
                    if (task.Name.Length > 15) task.popupStr = $"Одна из задач просрочилась!";
                    else task.popupStr = $"Задача \"{task.Name}\" просрочилась!";
                    task.popup.HeaderColor = Color.FromArgb(185, 28, 28);
                    task.popup.TitleColor = Color.FromArgb(185, 28, 28);
                    task.popup.ContentText = task.popupStr;
                    task.popup.Popup();
                    SortTasks();
                }


                task.LeftStringUpdate(now);
            }
            for (int i = 0; i < dgvTask.Rows.Count; i++)
            {
                var task = dgvTask.Rows[i].DataBoundItem as PlannerTask;

                if (task != null)
                {
                    bool isMouseOver = (i == hoveredRow);
                    Color color = task.GetCurrentColor(isMouseOver);

                    dgvTask.Rows[i].DefaultCellStyle.BackColor = color;
                    dgvTask.Rows[i].DefaultCellStyle.SelectionBackColor = color;
                    if (task.Status == 0)
                    {
                        dgvTask.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            int active = tasks.Count(t => t.Status == 1);
            int failed = tasks.Count(t => t.Status == 3);
            labelStats.Text = $"В работе: {active} | Провалено: {failed} | Всего: {tasks.Count}";
            dgvTask.Invalidate();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(form.NewTask);
                SaveData();
                SortTasks();
            }
            form.Dispose();
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Вы уверены? (Это действие - не выполнение задачи)", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var row = dgvTask.SelectedRows[0];
                    var selectedTask = row.DataBoundItem as PlannerTask;   
                    if (selectedTask != null)
                    {
                        tasks.Remove(selectedTask);
                    }
                    SaveData();
                    SortTasks();
                }
            }
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0)
            {
                var task = dgvTask.SelectedRows[0].DataBoundItem as PlannerTask;

                if (task.Status == 2)
                {
                    return; 
                }

                if (task.Status == 3)
                {
                    return; 
                }
                taskInfoHover.Hide();

                EditForm form = new EditForm(task);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveData(); 
                }

                dgvTask.Refresh(); 
                SortTasks();       
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void dgvTask_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (taskInfoHover.Visible)
            {
                taskInfoHover.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y - 150);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (PlannerTask task in tasks)
            {
                task.popup.Popup();
            }
        }
    }
}
