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
    public partial class EditForm : Form
    {
        private Task tasked;

        public EditForm(Task task)
        {
            InitializeComponent();
            tasked = task;

            nameInputEd.Text = task.Name;
            descriptionInputEd.Text = task.Description;

            dtmInputEd.Value = task.Deadline.Date;

            timeInputEd.Text = task.Deadline.ToString("HH:mm");
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInputEd.Text))
            {
                MessageBox.Show("Пожалуйста, введите название задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] formats = { @"h\:mm", @"hh\:mm" };

            if (TimeSpan.TryParseExact(timeInputEd.Text, formats, null, out TimeSpan time))
            {
                tasked.Name = nameInputEd.Text;
                tasked.Description = descriptionInputEd.Text;

                tasked.Deadline = dtmInputEd.Value.Date + time;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите время в формате ЧЧ:ММ (например, 09:30 или 14:15)", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
