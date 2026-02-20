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

namespace boom
{
    public partial class DgvHoverForm : Form
    {
        const int OffsetX = 15;
        const int OffsetY = 10;

        int dirName = -1;
        int dirDesc = -1;

        int pauseName = 0;
        int pauseDesc = 0;
        const int Wait = 10;    

        public DgvHoverForm()
        {
            InitializeComponent();

            timer1.Interval = 50;
            timer1.Tick += Timer_Tick;
            timer1.Start();

            this.DoubleBuffered = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NameScrl();
            DescScrl();
        }

        private void NameScrl()
        {
            if (labelName.Width > panelName.Width)
            {
                if (pauseName > 0) { pauseName--; return; }

                labelName.Left += dirName;

                if (labelName.Right <= panelName.Width - OffsetX && dirName == -1)
                {
                    dirName = 1;
                    pauseName = Wait;
                }
                else if (labelName.Left >= OffsetX && dirName == 1)
                {
                    dirName = -1;
                    pauseName = Wait;
                }
            }
        }

        private void DescScrl()
        {
            if (labelDesc.Height > panelDesc.Height)
            {
                if (pauseDesc > 0) { pauseDesc--; return; }

                labelDesc.Top += dirDesc;

                if (labelDesc.Bottom <= panelDesc.Height - OffsetY && dirDesc == -1)
                {
                    dirDesc = 1;
                    pauseDesc = Wait;
                }
                else if (labelDesc.Top >= OffsetY && dirDesc == 1)
                {
                    dirDesc = -1;
                    pauseDesc = Wait;
                }
            }
        }

        public void UpdateData(Task task)
        {
            labelName.Text = task.Name;
            labelDesc.Text = task.Description;

            if (labelName.Width > panelName.Width)
            {
                labelName.Left = OffsetX;
                dirName = -1;
            }
            else
            {
                labelName.Left = 0; 
                pauseName = 0;
            }


            if (labelDesc.Height > panelDesc.Height)
            {
                labelDesc.Top = OffsetY;
                dirDesc = -1;
            }
            else
            {
                labelDesc.Top = 0; 
                pauseDesc = 0;
            }

            UpdateStatD(task); 
        }

        private void UpdateStatD(Task task)
        {
            switch (task.Status)
            {
                case 0:
                    labelStatus.Text = $"Не начата. До: {task.Deadline:dd.MM.yyyy}\n{task.timeStr}";
                    labelStatus.ForeColor = Color.FromArgb(82, 82, 91);
                    break;
                case 1:
                    labelStatus.Text = $"В работе. До: {task.Deadline:dd.MM.yyyy}\n{task.timeStr}";
                    labelStatus.ForeColor = Color.FromArgb(59, 130, 246);
                    break;
                case 2:
                    labelStatus.Text = "✔️ Выполнено";
                    labelStatus.ForeColor = Color.FromArgb(21, 128, 61);
                    break;
                case 3:
                    labelStatus.Text = "❌ Просрочено";
                    labelStatus.ForeColor = Color.FromArgb(185, 28, 28);
                    break;
                default:
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    break;
            }
        }
    }
}