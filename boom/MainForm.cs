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

namespace boom
{
    public partial class MainForm : Form
    {
        BindingList<Task> tasks = new BindingList<Task>();
        Timer timer;
        DateTime now;
        //Image explosionImage = Properties.Resources.boomtest;
        bool rDgvTaskOpen = false;
        int hoveredRow = -1;
        int hoveredColumn = -1;
        DgvHoverForm taskInfoHover = new DgvHoverForm();

        public MainForm()
        {
            InitializeComponent();
            LoadData();

            dgvTask.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvTask.DefaultCellStyle.ForeColor = Color.White; 
            dgvTask.DataSource = tasks;

            DoubleBuffered = true;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();

            //dgvTask.RowPostPaint += dgvTask_RowPostPaint;
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
                    var loadedTasks = JsonConvert.DeserializeObject<List<Task>>(json);

                    tasks.Clear();
                    foreach (var task in loadedTasks)
                    {
                        tasks.Add(task);
                    }
                    SortTasks();
                }
                catch{}
            }
        }
        private void DgvTask_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            hoveredRow = e.RowIndex;
            hoveredColumn = e.ColumnIndex;

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as Task;
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
                Task task = tasks[hoveredRow];
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
                SortTasks();
                SaveData();
                dgvTask.Invalidate();
            }
        }



        //private void dgvTask_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    var task = dgvTask.Rows[e.RowIndex].DataBoundItem as Task;

        //    if (task != null && task.explodeAnimate)
        //    {
        //        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

        //        var rowRect = new Rectangle(0, e.RowBounds.Top, dgvTask.Columns.GetColumnsWidth(DataGridViewElementStates.Visible), e.RowBounds.Height);

        //        e.Graphics.DrawImage(explosionImage, rowRect);
        //    }
        //}

        private void Timer_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            foreach (Task task in tasks.ToList())
            {
                task.left = task.Deadline - now;
                if (!task.isOverdue && now > task.Deadline && task.Status != 2 )
                {
                    task.isOverdue = true;
                    //task.explodeAnimate = true;
                    //task.explodeStart = now;
                    task.Status = 3;  //
                    SortTasks();      //  вырежи если доделаешь ту хрень
                }
                //if (task.explodeStart.HasValue && now > task.explodeStart.Value.AddSeconds(2))
                //{
                //    task.explodeAnimate = false;
                //    task.explodeStart = null;
                //    task.Status = 3;
                //    SortTasks();
                //}
                task.LeftStringUpdate(now);
            }
            for (int i = 0; i < dgvTask.Rows.Count; i++) 
            {
                var task = dgvTask.Rows[i].DataBoundItem as Task;

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
                    var selectedTask = row.DataBoundItem as Task;   
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
                var task = dgvTask.SelectedRows[0].DataBoundItem as Task;

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
    }
}
