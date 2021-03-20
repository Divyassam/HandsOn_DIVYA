using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{

    public interface INotificationService
    {
        void AddSubscriber(AdminTeamObserver notificationObserver);
        void RemoveSubscriber(AdminTeamObserver notificationObserver);
        void NotifySubscriber(Event events);
    }



    public class NotificationService : INotificationService
    {
        public List<AdminTeamObserver> observers = new List<AdminTeamObserver>();
        public void AddSubscriber(AdminTeamObserver notificationObserver)
        {
            observers.Add(notificationObserver);
            Display(observers);
            Console.WriteLine("");
        }
        public void RemoveSubscriber(AdminTeamObserver notificationObserver)
        {
            observers.Remove(notificationObserver);
            Display(observers);
            Console.WriteLine("");
        }
        public void NotifySubscriber(Event events)
        {
            Console.WriteLine("\n\n---------------------------------\nNotification Sent");
            foreach (var i in observers) i.OnNotify(events);
            Console.WriteLine("--------------------------------\n\n");
        }

        public void Display(List<AdminTeamObserver> observers)
        {
            Console.Write("Current Observers : ");
            foreach (var i in observers) Console.Write(" - " + i.Name);
        }
    }

}