using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculateDueDatesExludingWeekends
{
    public class CalculateDueDatesHelper
    {
        public DateTime RecalculateDueDate(string priority, DateTime Today)
        {
            int days;
            int count;
            DateTime dueDate;

            count = 0;
            dueDate = Today;
            days = int.Parse(Regex.Replace(priority, "[^0-9]", ""));

            while (count < days)
            {
                dueDate = dueDate.AddDays(1);

                if ((int)dueDate.DayOfWeek != 0 && (int)dueDate.DayOfWeek != 6)
                    count++;
            }

            return dueDate;
        }
    }
}
