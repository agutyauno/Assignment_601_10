using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Tickets
{
    public class Ticket
    {
        int ticketID;

        public int TicketID { get => ticketID; set => ticketID = value; }
        public object TicketId { get; internal set; }
    }
}
