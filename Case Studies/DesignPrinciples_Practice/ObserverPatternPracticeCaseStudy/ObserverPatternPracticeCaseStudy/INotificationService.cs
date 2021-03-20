using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPracticeCaseStudy
{
    interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void RemoveSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();
    }


    //Concrete Notification
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            observers.Add(notificationObserver);
            Display(observers);
            Console.WriteLine("");
        }
        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            observers.Remove(notificationObserver);
            Display(observers); 
            Console.WriteLine("");
        }
        public void NotifySubscriber()
        {
            Console.WriteLine("\n\n---------------------------------\nNotification Sent");
            foreach (var i in observers) i.OnServerDown();
            Console.WriteLine("--------------------------------\n\n");
        }

        public void Display(List<INotificationObserver> observers)
        {
            Console.Write("Current Observers : ");
            foreach (var i in observers) Console.Write(" - "+i.Name);
        }
    }

}
