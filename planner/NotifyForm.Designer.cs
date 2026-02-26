namespace planner
{
    partial class NotifyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeInput1 = new System.Windows.Forms.MaskedTextBox();
            this.dtmInput1 = new CustomControls.RJControls.RJDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.Save1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Save1);
            this.panel1.Controls.Add(this.Cancel1);
            this.panel1.Controls.Add(this.dtmInput1);
            this.panel1.Controls.Add(this.timeInput1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 98);
            this.panel1.TabIndex = 0;
            // 
            // timeInput1
            // 
            this.timeInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.timeInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInput1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInput1.ForeColor = System.Drawing.Color.White;
            this.timeInput1.Location = new System.Drawing.Point(10, 24);
            this.timeInput1.Mask = "00:00";
            this.timeInput1.Name = "timeInput1";
            this.timeInput1.Size = new System.Drawing.Size(37, 25);
            this.timeInput1.TabIndex = 29;
            this.timeInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeInput1.ValidatingType = typeof(System.DateTime);
            // 
            // dtmInput1
            // 
            this.dtmInput1.BorderColor = System.Drawing.Color.DimGray;
            this.dtmInput1.BorderSize = 1;
            this.dtmInput1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtmInput1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtmInput1.CustomFormat = "";
            this.dtmInput1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtmInput1.Location = new System.Drawing.Point(53, 24);
            this.dtmInput1.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtmInput1.Name = "dtmInput1";
            this.dtmInput1.Size = new System.Drawing.Size(161, 25);
            this.dtmInput1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtmInput1.TabIndex = 28;
            this.dtmInput1.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Когда напомнить?";
            // 
            // Cancel1
            // 
            this.Cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.Cancel1.FlatAppearance.BorderSize = 0;
            this.Cancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel1.ForeColor = System.Drawing.Color.White;
            this.Cancel1.Location = new System.Drawing.Point(11, 55);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(66, 32);
            this.Cancel1.TabIndex = 31;
            this.Cancel1.Text = "Отмена";
            this.Cancel1.UseVisualStyleBackColor = false;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // Save1
            // 
            this.Save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.Save1.FlatAppearance.BorderSize = 0;
            this.Save1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save1.ForeColor = System.Drawing.Color.White;
            this.Save1.Location = new System.Drawing.Point(83, 55);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(131, 32);
            this.Save1.TabIndex = 32;
            this.Save1.Text = "Сохранить";
            this.Save1.UseVisualStyleBackColor = false;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // NotifyForm
            // 
            this.AcceptButton = this.Save1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(228, 100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotifyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox timeInput1;
        private CustomControls.RJControls.RJDatePicker dtmInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Cancel1;
    }
}