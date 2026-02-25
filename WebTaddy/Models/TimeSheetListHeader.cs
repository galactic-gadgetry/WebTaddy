using System;
using System.Collections.Generic;
using System.Text;

namespace WebTaddy.Models
{
    public class TimeSheetListHeader
    {
        /// <summary>
        /// Date for the list header.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Number of user-entered regular hours for the date.
        /// </summary>
        public double RegularHoursInput { get; set; } = 0;

        /// <summary>
        /// Number of scheduled hours for the date.
        /// </summary>
        public double ScheduledHours { get; set; } = 8;

        /// <summary>
        /// Number of user-entered telework hours for the date.
        /// </summary>
        public double TeleworkHoursInput { get; set; } = 0;

        /// <summary>
        /// Number of total hours for the date.
        /// </summary>
        public double TotalHours { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the
        /// <seealso cref="TimeSheetListHeader"/> class.
        /// </summary>
        /// <param name="date"></param>
        public TimeSheetListHeader(DateTime date)
        {
            Date = date;
        }
    }
}
