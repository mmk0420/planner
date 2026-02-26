using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planner
{
    public partial class NotifyForm : Form
    {
        public PlannerTask task1;
        public NotifyForm(PlannerTask task)
        {
            InitializeComponent();
            task1 = task;
            Save1.DialogResult = DialogResult.OK;
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            string[] formats = { @"h\:mm", @"hh\:mm" };
            if (TimeSpan.TryParseExact(timeInput1.Text, formats, null, out TimeSpan time))
            {
                DateTime Notif = dtmInput1.Value.Date + time;

                task1.notifyTimes.Add(Notif);
                MainForm.ScheduleTime(Notif, task1);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите время в формате ЧЧ:ММ (например, 09:30 или 14:15)", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
