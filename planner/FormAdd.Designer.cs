namespace planner
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.timeInput = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeadlineCheck = new System.Windows.Forms.CheckBox();
            this.NotifyBtn = new System.Windows.Forms.Button();
            this.dtmInput = new CustomControls.RJControls.RJDatePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(15, 4);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(333, 24);
            this.labelMain.TabIndex = 15;
            this.labelMain.Text = "Добавить задачу\r\n";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "До когда:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Имя:";
            // 
            // descriptionInput
            // 
            this.descriptionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.descriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionInput.ForeColor = System.Drawing.Color.White;
            this.descriptionInput.Location = new System.Drawing.Point(0, 0);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionInput.Size = new System.Drawing.Size(285, 69);
            this.descriptionInput.TabIndex = 24;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInput.ForeColor = System.Drawing.Color.White;
            this.nameInput.Location = new System.Drawing.Point(47, 28);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(301, 25);
            this.nameInput.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(333, 49);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timeInput
            // 
            this.timeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.timeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInput.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInput.ForeColor = System.Drawing.Color.White;
            this.timeInput.Location = new System.Drawing.Point(99, 131);
            this.timeInput.Mask = "00:00";
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(37, 25);
            this.timeInput.TabIndex = 27;
            this.timeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeInput.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionInput);
            this.panel1.Location = new System.Drawing.Point(80, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 69);
            this.panel1.TabIndex = 28;
            // 
            // DeadlineCheck
            // 
            this.DeadlineCheck.BackColor = System.Drawing.Color.Transparent;
            this.DeadlineCheck.Checked = true;
            this.DeadlineCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeadlineCheck.ForeColor = System.Drawing.Color.Black;
            this.DeadlineCheck.Location = new System.Drawing.Point(80, 131);
            this.DeadlineCheck.Name = "DeadlineCheck";
            this.DeadlineCheck.Size = new System.Drawing.Size(46, 25);
            this.DeadlineCheck.TabIndex = 25;
            this.DeadlineCheck.UseVisualStyleBackColor = false;
            // 
            // NotifyBtn
            // 
            this.NotifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.NotifyBtn.BackgroundImage = global::planner.Properties.Resources.plusss;
            this.NotifyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NotifyBtn.FlatAppearance.BorderSize = 0;
            this.NotifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotifyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotifyBtn.ForeColor = System.Drawing.Color.White;
            this.NotifyBtn.Location = new System.Drawing.Point(15, 159);
            this.NotifyBtn.Name = "NotifyBtn";
            this.NotifyBtn.Size = new System.Drawing.Size(50, 46);
            this.NotifyBtn.TabIndex = 29;
            this.NotifyBtn.UseVisualStyleBackColor = false;
            // 
            // dtmInput
            // 
            this.dtmInput.BorderColor = System.Drawing.Color.DimGray;
            this.dtmInput.BorderSize = 1;
            this.dtmInput.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtmInput.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtmInput.CustomFormat = "";
            this.dtmInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtmInput.Location = new System.Drawing.Point(142, 131);
            this.dtmInput.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtmInput.Name = "dtmInput";
            this.dtmInput.Size = new System.Drawing.Size(206, 25);
            this.dtmInput.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtmInput.TabIndex = 25;
            this.dtmInput.TextColor = System.Drawing.Color.White;
            // 
            // FormAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(360, 272);
            this.Controls.Add(this.NotifyBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.dtmInput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.DeadlineCheck);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Добавить задачу";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJDatePicker dtmInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox timeInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox DeadlineCheck;
        private System.Windows.Forms.Button NotifyBtn;
    }
}