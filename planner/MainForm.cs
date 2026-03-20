using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Tulpep.NotificationWindow;
using VkNet;
using VkNet.Abstractions;
using VkNet.Model;


namespace planner
{
    public partial class MainForm : Form
    {
        
        public static bool editMode { get; set;  }
        BindingList<PlannerTask> tasks = new BindingList<PlannerTask>();
        System.Windows.Forms.Timer timer;
        DateTime now;
        int hoveredRow = -1;
        int hoveredColumn = -1;
        DgvHoverForm taskInfoHover = new DgvHoverForm();
        bool rcBlock = false;
        private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);
        bool isHoveredVK = false;

        static VkApi vkApi = new VkApi();
        public static string token = null;
        public static long? ID = null;


        public MainForm()
        {
            InitializeComponent();
            LoadData();
            if (ID != null && token != null)
            {
                try { VkLoad(); } catch { }
            }

            List<string> missedNotifications = new List<string>();
            bool needsSave = false;

            foreach (PlannerTask task in tasks.ToList())
            {
                if (task.notifyTimes != null)
                {
                    foreach (DateTime dtt in task.notifyTimes.ToList())
                    {
                        if (dtt < DateTime.Now)
                        {
                            missedNotifications.Add($"- {task.Name} ({dtt:HH:mm})");
                            task.notifyTimes.Remove(dtt);
                            needsSave = true;
                        }
                        else
                        {
                            ScheduleTime(dtt, task);
                        }
                    }
                }
            }

            if (missedNotifications.Count > 0)
            {
                string missedText = string.Join("\n", missedNotifications);
                if (missedText.Length > 150) missedText = missedText.Substring(0, 147) + "...";

                _ = ShowNewPopup("Пропущено!", $"Пока вас не было:\n{missedText}", Color.FromArgb(185, 28, 28), true);
            }

            if (needsSave) SaveData();

            this.Icon = Properties.Resources.icon;
            TrayIcon.Icon = Properties.Resources.icon;

            dgvTask.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvTask.DefaultCellStyle.ForeColor = Color.White; 
            dgvTask.DataSource = tasks;

            DoubleBuffered = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            dgvTask.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTask.GridColor = dgvTask.BackgroundColor;
            dgvTask.CellMouseDown += dgvTask_CellMouseDown;
            dgvTask.CellMouseEnter += DgvTask_CellMouseEnter;
            dgvTask.CellMouseLeave += DgvTask_CellMouseLeave;
            dgvTask.DataBindingComplete += DgvTask_DataBindingComplete;


            buttonVk.MouseEnter += buttonVk_MouseEnter;
            buttonVk.MouseLeave += buttonVk_MouseLeave;
        }



        private async void buttonVk_MouseEnter(object sender, EventArgs e)
        {
            isHoveredVK = true; 

            while (isHoveredVK && buttonVk.Left > 200)
            {
                buttonVk.Left -= 1; 
                await Task.Delay(5); 
            }
        }

        private async void buttonVk_MouseLeave(object sender, EventArgs e)
        {
            isHoveredVK = false;


            while (!isHoveredVK && buttonVk.Left < 239)
            {
                buttonVk.Left += 1; 
                await Task.Delay(5);
            }
        }

        private void DgvTask_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvTask.Rows.Count; i++)
            {
                var task = dgvTask.Rows[i].DataBoundItem as PlannerTask;

                if (task != null)
                {
                    if (i != hoveredRow)
                    {
                        Color normalColor = task.GetCurrentColor(false);
                        dgvTask.Rows[i].DefaultCellStyle.BackColor = normalColor;
                        dgvTask.Rows[i].DefaultCellStyle.SelectionBackColor = normalColor;

                        if (task.Status == 0)
                        {
                            dgvTask.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private async static void VkLoad()
        {
            try
            {
                await vkApi.AuthorizeAsync(new ApiAuthParams { AccessToken = token });
            }
            catch (Exception) {  }
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
                var dataToSave = new PlannerSaveData
                {
                    Tasks = tasks.ToList(), 
                    VkId = ID,
                    VkToken = token
                };
                string json = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);
                File.WriteAllText("save_planner.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
        private void LoadData()
        {
            if (!File.Exists("save_planner.json")) return;

            try
            {
                string json = File.ReadAllText("save_planner.json");

                var data = JsonConvert.DeserializeObject<PlannerSaveData>(json);

                if (data != null)
                {
                    ID = data.VkId;
                    token = data.VkToken;

                    tasks.Clear();
                    if (data.Tasks != null)
                    {
                        foreach (var task in data.Tasks)
                        {
                            tasks.Add(task);
                        }
                    }
                    SortTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }
        private void DgvTask_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (!rcBlock)
            {
                hoveredRow = e.RowIndex;
                hoveredColumn = e.ColumnIndex;
            }

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as PlannerTask;
            if (task != null)
            {
                Color hoverColor = task.GetCurrentColor(true);
                dgvTask.Rows[e.RowIndex].DefaultCellStyle.BackColor = hoverColor;
                dgvTask.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = hoverColor;

                taskInfoHover.UpdateData(task);
                taskInfoHover.Show();
            }
        }

        private void DgvTask_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as PlannerTask;
            if (task != null)
            {
                Color normalColor = task.GetCurrentColor(false);
                dgvTask.Rows[e.RowIndex].DefaultCellStyle.BackColor = normalColor;
                dgvTask.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = normalColor;
            }

            if (!rcBlock)
            {
                hoveredRow = -1;
                hoveredColumn = -1;
            }
            taskInfoHover.Hide();
        }


        private bool isProcessingClick = false;

        private void dgvTask_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (isProcessingClick) return;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            hoveredRow = e.RowIndex;
            hoveredColumn = e.ColumnIndex;

            if (e.Button == MouseButtons.Right && hoveredRow >= 0 && hoveredColumn >= 0)
            {
                dgvTask.Rows[hoveredRow].Selected = true;
                taskInfoHover.Hide();
            }

            if (e.Button == MouseButtons.Left && hoveredRow >= 0 && hoveredColumn >= 0)
            {
                isProcessingClick = true;

                PlannerTask task = tasks[hoveredRow];
                if (task.Status == 2 || task.Status == 3)
                {
                    isProcessingClick = false;
                    return;
                }

                task.Status = task.Status == 0 ? 1 : 2;
                taskInfoHover.UpdateData(task);

                this.BeginInvoke(new Action(() =>
                {
                    SortTasks();
                    SaveData();
                    dgvTask.Invalidate();
                    isProcessingClick = false;
                }));
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            foreach (PlannerTask task in tasks.ToList())
            {
                task.left = task.Deadline - now;

                if (!task.isOverdue && now > task.Deadline && task.Status != 2)
                {
                    string popupStr;
                    task.isOverdue = true;
                    task.Status = 3;
                    if (task.Name.Length > 15) popupStr = $"Одна из задач просрочилась!";
                    else popupStr = $"Задача \"{task.Name}\" просрочилась!";
                    _ = ShowNewPopup("Провалено!", popupStr, Color.FromArgb(185, 28, 28), true);
                    SortTasks();
                }


                task.LeftStringUpdate(now);
            }
            int active = tasks.Count(t => t.Status == 1);
            int failed = tasks.Count(t => t.Status == 3);
            labelStats.Text = $"В работе: {active} | Провалено: {failed} | Всего: {tasks.Count}";
            dgvTask.Invalidate();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            editMode = false;
            FormAdd form = new FormAdd(null);
            form.Location = new Point(this.Location.X - 45, this.Location.Y + 30);
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
            if (dgvTask.SelectedRows.Count == 1 && hoveredRow != -1 && hoveredColumn != -1)
            {
                DialogResult result = MessageBox.Show("Вы уверены? (Это действие - не выполнение задачи)", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var row = dgvTask.SelectedRows[0];
                    var selectedTask = row.DataBoundItem as PlannerTask;   
                    if (selectedTask != null)
                    {
                        selectedTask.Cts.Cancel();
                        selectedTask.notifyTimes.Clear();
                        tasks.Remove(selectedTask);
                    }
                    SaveData();
                    SortTasks();
                }
                hoveredRow = -1;
                hoveredColumn = -1;
            }
            else
            {
                _ = ShowNewPopup("Внимание!", "Наведитесь на задачу, которую вы хотите удалить!", Color.FromArgb(255, 191, 0), false);
            }
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0 && hoveredColumn != -1 && hoveredRow != -1)
            {
                var row = dgvTask.SelectedRows[0];
                var task = row.DataBoundItem as PlannerTask;

                if (task.Status == 2)
                {
                    return; 
                }

                if (task.Status == 3)
                {
                    return; 
                }
                taskInfoHover.Hide();

                editMode = true;
                FormAdd form = new FormAdd(task);
                form.Location = new Point(this.Location.X - 45, this.Location.Y + 30);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveData(); 
                }
                hoveredRow = -1;
                hoveredColumn = -1;
                dgvTask.Refresh(); 
                SortTasks();       
            }
            else
            {
                _ = ShowNewPopup("Внимание!", "Наведитесь на задачу, которую вы хотите изменить!", Color.FromArgb(255, 191, 0), false);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
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
            _ = ShowNewPopup("Тест", "Если вы это нашли не трогайте плз :3", Color.Pink, true);
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
                SaveData();
            }
        }

        private void планировщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        public static async Task ShowNewPopup(string title, string text, Color? customColor, bool vk)
        {
            await semaphoreSlim.WaitAsync();

            try
            {
                var tcs = new TaskCompletionSource<bool>();
                PopupNotifier popup = new PopupNotifier();

                popup.BodyColor = Color.FromArgb(45, 45, 48);
                popup.BorderColor = Color.FromArgb(60, 60, 65);
                popup.GradientPower = 0;

                popup.TitleText = title;
                if (customColor != null)
                {
                    popup.TitleColor = (Color)customColor;
                    popup.HeaderColor = (Color)customColor;
                }
                else
                {
                    popup.TitleColor = Color.FromArgb(0, 190, 255);
                    popup.HeaderColor = Color.FromArgb(0, 122, 204);
                }
                popup.TitleFont = new Font("Segoe UI", 15, FontStyle.Bold);

                popup.ContentText = text;
                popup.ContentColor = Color.White;
                popup.ContentFont = new Font("Segoe UI", 12);

                popup.ShowGrip = false;
                popup.Delay = 4000;
                popup.AnimationDuration = 1000;
                popup.AnimationInterval = 10;

                popup.Size = new Size(400, 210);

                popup.Image = Properties.Resources.iconPNG;

                popup.Disappear += (s, e) => tcs.TrySetResult(true);

                popup.Popup();

                if (ID != null && token != null && vk)
                {

                    try
                    {
                        await vkApi.Messages.SendAsync(new MessagesSendParams
                        {
                            UserId = ID,
                            RandomId = new Random().Next(),
                            Message = $"»» {title} ««\n ——————— \n{text}\n ——————— "
                        });
                    }
                    catch (Exception) {  }
                }

                await tcs.Task;
            }
            finally
            {
                semaphoreSlim.Release();
            }
        }

        public static async void ScheduleTime(DateTime time, PlannerTask task)
        {
            bool isNotified = false;
            TimeSpan left = time - DateTime.Now;

            if (left > TimeSpan.Zero)
            {
                try
                {
                    await Task.Delay(left, task.Cts.Token);
                }
                catch (TaskCanceledException)
                {
                    return;
                }

                if (!task.notifyTimes.Contains(time)) return;

                string popupStr = task.Name.Length > 15
                    ? $"Вы просили напомнить об одной из задач!"
                    : $"Вы просили напомнить о задаче \"{task.Name}\"!";

                _ = ShowNewPopup("Напоминание", popupStr, null, true);
                task.notifyTimes.Remove(time);
                isNotified = true;
            }
            else if (!isNotified)
            {
                if (!task.notifyTimes.Contains(time)) return;

                string popupStr = task.Name.Length > 15
                    ? $"Время напоминания одной из задач истекло!"
                    : $"Время напоминания задачи \"{task.Name}\" истекло!";

                _ = ShowNewPopup("Внимание!", popupStr, Color.FromArgb(185, 28, 28), true);
                task.notifyTimes.Remove(time);
            }
        }

        private void добавитьНапоминаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0 && hoveredRow != -1 && hoveredColumn != -1)
            {
                var row = dgvTask.SelectedRows[0];
                var task = row.DataBoundItem as PlannerTask;
                if (task.Status == 2)
                {
                    return;
                }
                if (task.Status == 3)
                {
                    return;
                }
                taskInfoHover.Hide();

                NotifyForm form = new NotifyForm(task);
                form.Location = new Point(Cursor.Position.X - form.Width/2, Cursor.Position.Y - form.Height/2);       
                if (form.ShowDialog() == DialogResult.OK)
                {
                    task.notifyTimes = form.task1.notifyTimes;
                    SaveData();
                }
                hoveredRow = -1;
                hoveredColumn = -1;
            }
            else
            {
                _ = ShowNewPopup("Внимание!", "Наведитесь на задачу, к которой вы хотите привязать напоминание!", Color.FromArgb(255, 191, 0), false);
            }
        }

        private void rcDgvTask_Opening(object sender, CancelEventArgs e)
        {
            rcBlock = true;
            ToolStripMenuItem item = НапоминанияToolStripMenuItem;

            for (int i = item.DropDownItems.Count - 1; i >= 0; i--)
            {
                if (item.DropDownItems[i].Text != "Добавить напоминание")
                {
                    item.DropDownItems.RemoveAt(i);
                }
            }

            foreach (PlannerTask task in tasks)
            {
                if (task.notifyTimes == null) continue;

                foreach (DateTime time in task.notifyTimes)
                {
                    string finalString = $"\"{task.Name}\" : {time:dd.MM HH:mm}";
                    var nitem = new ToolStripMenuItem(finalString);

                    nitem.BackColor = Color.FromArgb(45, 45, 48);
                    nitem.ForeColor = Color.White;

                    nitem.Tag = time;

                    nitem.Click += (s, m) =>
                    {
                        if (MessageBox.Show("Удалить напоминание?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DateTime timeToRemove = (DateTime)((ToolStripMenuItem)s).Tag;

                            task.notifyTimes.Remove(timeToRemove);

                            item.DropDownItems.Remove((ToolStripMenuItem)s);
                        }
                    };

                    item.DropDownItems.Add(nitem);
                }
            }
        }

        private void rcDgvTask_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            rcBlock = false;
        }

        private void buttonVk_Click(object sender, EventArgs e)
        {
            VKlink form = new VKlink();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                token = form.token;
                ID = form.ID;
                VkLoad();
            }
        }
    }
}
