using System;
using System.Collections.Generic;
using System.Text;

namespace Augmentations
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets the time passed from now
        /// </summary>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

        /// <summary>
        /// Gets weeknumber
        /// </summary>
        public static int WeekOfYear(this DateTime datetime, System.Globalization.CalendarWeekRule weekrule = System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek firstDayOfWeek = DayOfWeek.Monday)
        {
            System.Globalization.CultureInfo ciCurr = System.Globalization.CultureInfo.CurrentCulture;
            return ciCurr.Calendar.GetWeekOfYear(datetime, weekrule, firstDayOfWeek);
        }

    }
}
