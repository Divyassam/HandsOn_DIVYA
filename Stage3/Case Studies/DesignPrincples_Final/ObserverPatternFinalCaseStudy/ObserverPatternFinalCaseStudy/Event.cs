using System;
using System.Collections.Generic;
using System.Text;
using static ObserverPatternFinalCaseStudy.INotificationService;

namespace ObserverPatternFinalCaseStudy
{
    public class Event
    {
        public string Name { get; set; }
        public int TicketCount { get; set; }
        public Event(string name,int ticketCount, INotificationService service)
        {
            Name = name;
            TicketCount = ticketCount;
            if (ticketCount > 100)
            {
                service.NotifySubscriber(this);
            }
        }

    }
}
