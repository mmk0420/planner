namespace boom
{
    partial class EditForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionInputEd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInputEd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.dtmInputEd = new CustomControls.RJControls.RJDatePicker();
            this.timeInputEd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "До когда:";
            // 
            // descriptionInputEd
            // 
            this.descriptionInputEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.descriptionInputEd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionInputEd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionInputEd.ForeColor = System.Drawing.Color.White;
            this.descriptionInputEd.Location = new System.Drawing.Point(80, 59);
            this.descriptionInputEd.Multiline = true;
            this.descriptionInputEd.Name = "descriptionInputEd";
            this.descriptionInputEd.Size = new System.Drawing.Size(251, 66);
            this.descriptionInputEd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Описание:";
            // 
            // nameInputEd
            // 
            this.nameInputEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nameInputEd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInputEd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInputEd.ForeColor = System.Drawing.Color.White;
            this.nameInputEd.Location = new System.Drawing.Point(47, 28);
            this.nameInputEd.Name = "nameInputEd";
            this.nameInputEd.Size = new System.Drawing.Size(284, 25);
            this.nameInputEd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Изменить задачу\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnEditSave.FlatAppearance.BorderSize = 0;
            this.btnEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSave.ForeColor = System.Drawing.Color.White;
            this.btnEditSave.Location = new System.Drawing.Point(12, 162);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(319, 53);
            this.btnEditSave.TabIndex = 23;
            this.btnEditSave.Text = "Сохранить";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // dtmInputEd
            // 
            this.dtmInputEd.BorderColor = System.Drawing.Color.DimGray;
            this.dtmInputEd.BorderSize = 1;
            this.dtmInputEd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtmInputEd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtmInputEd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtmInputEd.Location = new System.Drawing.Point(123, 131);
            this.dtmInputEd.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtmInputEd.Name = "dtmInputEd";
            this.dtmInputEd.Size = new System.Drawing.Size(208, 25);
            this.dtmInputEd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtmInputEd.TabIndex = 22;
            this.dtmInputEd.TextColor = System.Drawing.Color.White;
            // 
            // timeInputEd
            // 
            this.timeInputEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.timeInputEd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInputEd.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInputEd.ForeColor = System.Drawing.Color.White;
            this.timeInputEd.Location = new System.Drawing.Point(80, 131);
            this.timeInputEd.Mask = "00:00";
            this.timeInputEd.Name = "timeInputEd";
            this.timeInputEd.Size = new System.Drawing.Size(37, 25);
            this.timeInputEd.TabIndex = 28;
            this.timeInputEd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeInputEd.ValidatingType = typeof(System.DateTime);
            // 
            // EditForm
            // 
            this.AcceptButton = this.btnEditSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(340, 227);
            this.Controls.Add(this.timeInputEd);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.dtmInputEd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionInputEd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameInputEd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionInputEd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInputEd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJDatePicker dtmInputEd;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.MaskedTextBox timeInputEd;
    }
}