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
    public partial class FormAdd : Form
    {
        public PlannerTask NewTask { get; private set; }
        public FormAdd()
        {
            InitializeComponent();
            dtmInput.Value = DateTime.Now;
            timeInput.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите название задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] formats = { @"h\:mm", @"hh\:mm" };
            if (TimeSpan.TryParseExact(timeInput.Text, formats, null, out TimeSpan time))
            {
                NewTask = new PlannerTask
                {
                    Name = nameInput.Text.Trim(),
                    Description = descriptionInput.Text,
                    Deadline = dtmInput.Value.Date + time,
                    timeStr = time.ToString(@"hh\:mm")
                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите время в формате ЧЧ:ММ (например, 09:30 или 14:15)", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
