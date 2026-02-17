using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boom
{
    public partial class DgvHoverForm : Form
    {
        public DgvHoverForm()
        {
            InitializeComponent();
            timer1.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (labelName.Text.Length > 20)
            {
                string text = labelName.Text;
                labelName.Text = text.Substring(1) + text[0];
            }

            //if (labelDesc.Height > pnlDesc.Height)
            //{
            //    labelDesc.Top = 0;
            //    return;
            //}
            //labelDesc.Top -= 1;
            //if (labelDesc.Top + labelDesc.Height < 0)
            //{
            //    labelDesc.Top = pnlDesc.Height;
            //}
        }

        public void UpdateData(Task task)
        {
            labelName.Text = task.Name.PadRight(task.Name.Length + 5, ' ');
            labelDesc.Text = task.Description;

            switch (task.Status)
            {
                case 0:
                    labelStatus.Text = "Не начата. До: " + task.Deadline.ToString();
                    break;
                case 1:
                    labelStatus.Text = "В работе. До: " + task.Deadline.ToString();
                    break;
                case 2:
                    labelStatus.Text = "✔️ Выполнено";
                    break;
                case 3:
                    labelStatus.Text = "❌ Просрочено";
                    break;
                default:
                    labelStatus.Text = "Ошибка";
                    break;
            }
        }
    }
}
