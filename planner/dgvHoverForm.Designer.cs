namespace planner
{
    partial class DgvHoverForm
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDesc = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelDesc = new System.Windows.Forms.Panel();
            this.panelName.SuspendLayout();
            this.panelDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(-1, 0);
            this.labelName.MaximumSize = new System.Drawing.Size(0, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(12, 130);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(197, 41);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesc.ForeColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(-1, 0);
            this.labelDesc.MaximumSize = new System.Drawing.Size(176, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(76, 17);
            this.labelDesc.TabIndex = 4;
            this.labelDesc.Text = "Описание";
            // 
            // panelName
            // 
            this.panelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Location = new System.Drawing.Point(12, 12);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(197, 25);
            this.panelName.TabIndex = 5;
            // 
            // panelDesc
            // 
            this.panelDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesc.Controls.Add(this.labelDesc);
            this.panelDesc.Location = new System.Drawing.Point(12, 41);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(197, 87);
            this.panelDesc.TabIndex = 6;
            // 
            // DgvHoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(221, 180);
            this.Controls.Add(this.panelDesc);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DgvHoverForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "dgvHoverForm";
            this.TopMost = true;
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelDesc;
    }
}