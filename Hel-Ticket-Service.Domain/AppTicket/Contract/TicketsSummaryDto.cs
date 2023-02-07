using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hel_Ticket_Service.Domain.AppTicket.Contract
{
    public class TicketsSummaryDto
    {
        public int TotalOpenTickets { get; set; }
        public int TotalClosedTickets { get; set; }
        public int TotalActiveTickets { get; set; }
        public int TotalEscalatedTickets { get; set; }
    }
}