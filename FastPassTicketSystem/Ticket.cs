using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPassTicketSystem
{
    /// <summary>
    /// Represents a single ticket
    /// </summary>
    class Ticket
    {
        public int TicketNumber 
        {
            get 
            {
                int value = CreateTicketNumber();
                return value;
            }
            private set 
            {
                TicketNumber = value;
            }
        }

        public TimeSlot Slot { get; set; }

        private int CreateTicketNumber()
        {
            Random random = new Random();
            int number = random.Next(0 - 1000000);
            return number;
        }
    }
}
