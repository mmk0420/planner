using Newtonsoft.Json;
using planner.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace planner
{
    public class PlannerTask
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } //0 не начата 1 начата 2 выполнена 3 просрочена
        public DateTime Deadline { get; set; }
        public string timeStr { get; set; }
        public bool isOverdue { get; set; } = false;
        //public List<string> notifyTimeString { get; set; } = new List<string>();
        public List<DateTime> notifyTimes { get; set; } = new List<DateTime>();

        [JsonIgnore]
        public TimeSpan left { get; set; }
        [JsonIgnore]
        public string leftString { get; set; }
        public int Notification { get; set; } = 0;
        [JsonIgnore]
        public CancellationTokenSource Cts { get; set; } = new CancellationTokenSource();


        public PlannerTask()
        {
            Status = 0;
        }

        public Color GetCurrentColor(bool isHovered)
        {
            switch (Status)
            {
                case 1:
                    return isHovered ? Color.FromArgb(37, 99, 235) : Color.FromArgb(30, 58, 138);
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

            if (left.TotalSeconds <= 0) { leftString = "00:00:00"; return; }

            if (left.TotalHours < 24)
            {
                leftString = left.ToString(@"hh\:mm\:ss");
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
            else if (left.TotalDays >= 7)
            {
                int weeks = (int)(left.TotalDays / 7);
                int remDays = (int)(left.TotalDays % 7);
                leftString = $"{weeks} нед. {remDays} дн.";
            }
            else
            {
                leftString = $"{left.Days} дн. {left.Hours} ч.";
            }
        }
    }
}



