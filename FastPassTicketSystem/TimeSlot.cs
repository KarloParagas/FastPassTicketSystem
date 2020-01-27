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
    class TimeSlot
    {
        public DateTime _startTime;
        public DateTime _endTime;
        public TimeSpan _timeSlotLength;

        public DateTime _time { get; set; }

        public int _numberOfTickets { get; set; }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime 
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public TimeSpan TimeSlotLength
        {
            get { return _timeSlotLength; }
            set { _timeSlotLength = _endTime - _startTime; }
        }
    }
}
