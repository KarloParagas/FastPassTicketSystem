using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPassTicketSystem
{
    /// <summary>
    /// A class that represents the time slot for assigning tickets
    /// </summary>
    public class TimeSlot
    {
        public int _numberOfTickets { get; set; }

        /// <summary>
        /// Obtains the current time
        /// </summary>
        public DateTime Time 
        {
            get { return Time; }
            private set { Time = DateTime.Now; }
        }

        /// <summary>
        /// Obtains the start time provided in the Options form
        /// </summary>
        public DateTime StartTime
        {
            get { return StartTime; }
            private set { StartTime = value; }
        }

        /// <summary>
        /// Calculates the time slot's length based on the current time, and the start time
        /// </summary>
        public TimeSpan TimeSlotLength
        {
            get { return TimeSlotLength; }
            private set { TimeSlotLength = Time - StartTime; }
        }
    }
}
