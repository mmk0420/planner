using boom.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace boom
{
    public class Task
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } //0 не начата 1 начата 2 выполнена 3 просрочена
        public DateTime Deadline { get; set; }
        public bool isOverdue { get; set; } = false;
        //public bool explodeAnimate { get; set; } = false;
        //public DateTime? explodeStart { get; set; } = null;
        [JsonIgnore]
        public TimeSpan left { get; set; }
        [JsonIgnore]
        public string leftString { get; set; }
        public int Notification { get; set; } = -1225; // -1 - не уведомлять 0 трижды 1 дважды 2 единожды -1225 стандартное
        public string popupStr { get; set; } = "";
        [JsonIgnore]
        public PopupNotifier popup { get; set; } = new PopupNotifier();


        public Task()
        {
            Status = 0;
            popup.BodyColor = Color.FromArgb(45, 45, 48);
            popup.HeaderColor = Color.FromArgb(0, 122, 204);
            popup.BorderColor = Color.FromArgb(60, 60, 65);
            popup.GradientPower = 0;

            popup.TitleText = "НАПОМИНАНИЕ";
            popup.TitleColor = Color.FromArgb(0, 190, 255);
            popup.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);

            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Segoe UI", 10);

            popup.ShowGrip = false;
            popup.Delay = 4000;
            popup.AnimationDuration = 1000;
            popup.AnimationInterval = 10;

            popup.Image = MainForm.popIMG;
        }

        public Color GetCurrentColor(bool isHovered)
        {
            switch (Status)
            {
                case 1: 
                    return isHovered ? Color.FromArgb(161, 98, 7) : Color.FromArgb(133, 77, 14);
                case 2: 
                    return isHovered ? Color.FromArgb(21, 128, 61) : Color.FromArgb(20, 83, 45);
                case 3: 
                    return isHovered ? Color.FromArgb(185, 28, 28) : Color.FromArgb(127, 29, 29);
                default: 
                    return isHovered ? Color.FromArgb(82, 82, 91) : Color.FromArgb(63, 63, 70);
            }
        }


        public void LeftStringUpdate(DateTime now)
        {
            if (Status == 2) { leftString = "✔️ Выполнено"; return; }
            if (Status == 3) { leftString = "❌ Просрочено"; return; }

            TimeSpan diff = Deadline - now;

            if (diff.TotalSeconds <= 0) { leftString = "00:00:00"; return; }

            if (diff.TotalHours < 24)
            {
                leftString = diff.ToString(@"hh\:mm\:ss");
                return;
            }

            DateTime target = Deadline;
            int years = target.Year - now.Year;
            int months = target.Month - now.Month;
            int days = target.Day - now.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(now.Year, now.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            if (years > 0)
            {
                leftString = $"{years} г. {months} мес.";
            }
            else if (months > 0)
            {
                int weeks = days / 7;
                int remainingDays = days % 7;

                if (weeks > 0)
                    leftString = $"{months} мес. {weeks} нед.";
                else
                    leftString = $"{months} мес. {days} дн.";
            }
            else if (diff.TotalDays >= 7)
            {
                int weeks = (int)(diff.TotalDays / 7);
                int remDays = (int)(diff.TotalDays % 7);
                leftString = $"{weeks} нед. {remDays} дн.";
            }
            else
            {
                leftString = $"{diff.Days} дн. {diff.Hours} ч.";
            }
        }
    }
}



