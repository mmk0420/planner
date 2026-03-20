namespace planner
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rcDgvTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.НапоминанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНапоминаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTask = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.планировщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVk = new System.Windows.Forms.Button();
            this.dgvTask = new planner.DoubleBufferedDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcDgvTask.SuspendLayout();
            this.TrayCMS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rcDgvTask
            // 
            this.rcDgvTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rcDgvTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rcDgvTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcDgvTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.НапоминанияToolStripMenuItem,
            this.EditTask,
            this.удалитьToolStripMenuItem});
            this.rcDgvTask.Name = "rcDgvTask";
            this.rcDgvTask.ShowImageMargin = false;
            this.rcDgvTask.Size = new System.Drawing.Size(134, 70);
            this.rcDgvTask.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.rcDgvTask_Closing);
            this.rcDgvTask.Opening += new System.ComponentModel.CancelEventHandler(this.rcDgvTask_Opening);
            // 
            // НапоминанияToolStripMenuItem
            // 
            this.НапоминанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНапоминаниеToolStripMenuItem});
            this.НапоминанияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.НапоминанияToolStripMenuItem.Name = "НапоминанияToolStripMenuItem";
            this.НапоминанияToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.НапоминанияToolStripMenuItem.Text = "Напоминания";
            // 
            // добавитьНапоминаниеToolStripMenuItem
            // 
            this.добавитьНапоминаниеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.добавитьНапоминаниеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.добавитьНапоминаниеToolStripMenuItem.Name = "добавитьНапоминаниеToolStripMenuItem";
            this.добавитьНапоминаниеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.добавитьНапоминаниеToolStripMenuItem.Text = "Добавить напоминание";
            this.добавитьНапоминаниеToolStripMenuItem.Click += new System.EventHandler(this.добавитьНапоминаниеToolStripMenuItem_Click);
            // 
            // EditTask
            // 
            this.EditTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditTask.ForeColor = System.Drawing.Color.White;
            this.EditTask.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(133, 22);
            this.EditTask.Text = "Изменить";
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.удалитьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteTask);
            // 
            // labelStats
            // 
            this.labelStats.Location = new System.Drawing.Point(0, 237);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(246, 16);
            this.labelStats.TabIndex = 3;
            this.labelStats.Text = "label1";
            this.labelStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "➕";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 19);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayCMS;
            this.TrayIcon.Text = "Планировщик";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayCMS
            // 
            this.TrayCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TrayCMS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrayCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планировщикToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.TrayCMS.Name = "TrayCMS";
            this.TrayCMS.ShowImageMargin = false;
            this.TrayCMS.Size = new System.Drawing.Size(102, 48);
            // 
            // планировщикToolStripMenuItem
            // 
            this.планировщикToolStripMenuItem.AutoSize = false;
            this.планировщикToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.планировщикToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.планировщикToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.планировщикToolStripMenuItem.Name = "планировщикToolStripMenuItem";
            this.планировщикToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.планировщикToolStripMenuItem.Text = "Открыть";
            this.планировщикToolStripMenuItem.Click += new System.EventHandler(this.планировщикToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.выходToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVk);
            this.panel1.Controls.Add(this.dgvTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 234);
            this.panel1.TabIndex = 6;
            // 
            // buttonVk
            // 
            this.buttonVk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonVk.FlatAppearance.BorderSize = 0;
            this.buttonVk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVk.ForeColor = System.Drawing.Color.White;
            this.buttonVk.Location = new System.Drawing.Point(239, 190);
            this.buttonVk.Name = "buttonVk";
            this.buttonVk.Size = new System.Drawing.Size(46, 29);
            this.buttonVk.TabIndex = 7;
            this.buttonVk.Text = "VK";
            this.buttonVk.UseVisualStyleBackColor = false;
            this.buttonVk.Click += new System.EventHandler(this.buttonVk_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AllowUserToOrderColumns = true;
            this.dgvTask.AllowUserToResizeColumns = false;
            this.dgvTask.AllowUserToResizeRows = false;
            this.dgvTask.AutoGenerateColumns = false;
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTask.ColumnHeadersVisible = false;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.leftStringDataGridViewTextBoxColumn});
            this.dgvTask.ContextMenuStrip = this.rcDgvTask;
            this.dgvTask.DataSource = this.taskBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTask.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTask.EnableHeadersVisualStyles = false;
            this.dgvTask.GridColor = System.Drawing.Color.Black;
            this.dgvTask.Location = new System.Drawing.Point(0, 0);
            this.dgvTask.MultiSelect = false;
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.RowHeadersWidth = 5;
            this.dgvTask.RowTemplate.Height = 50;
            this.dgvTask.RowTemplate.ReadOnly = true;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(264, 234);
            this.dgvTask.TabIndex = 2;
            this.dgvTask.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTask_CellMouseDown);
            this.dgvTask.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTask_CellMouseEnter);
            this.dgvTask.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTask_CellMouseLeave);
            this.dgvTask.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTask_CellMouseMove);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leftStringDataGridViewTextBoxColumn
            // 
            this.leftStringDataGridViewTextBoxColumn.DataPropertyName = "leftString";
            this.leftStringDataGridViewTextBoxColumn.HeaderText = "leftString";
            this.leftStringDataGridViewTextBoxColumn.Name = "leftStringDataGridViewTextBoxColumn";
            this.leftStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(planner.PlannerTask);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(246, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelStats);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планировщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.rcDgvTask.ResumeLayout(false);
            this.TrayCMS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DoubleBufferedDataGridView dgvTask;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.ContextMenuStrip rcDgvTask;
        private System.Windows.Forms.ToolStripMenuItem EditTask;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayCMS;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планировщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem НапоминанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНапоминаниеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVk;
    }
}

