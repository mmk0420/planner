using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public void UpdateData(Task task)
        {
            labelName.Text = task.Name;
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
                    labelStatus.Text = task.leftString;
                    break;
                case 3:
                    labelStatus.Text = task.leftString;
                    break;
                default:
                    labelStatus.Text = "Ошибка";
                    break;
            }
        }
    }
}
