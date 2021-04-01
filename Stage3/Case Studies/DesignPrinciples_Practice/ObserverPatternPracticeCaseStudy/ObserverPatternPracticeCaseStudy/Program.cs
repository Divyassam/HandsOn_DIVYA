using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPracticeCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver Steve1 = new SteveObserver();
            INotificationObserver John1= new JohnObserver();
            INotificationService service = new NotificationService();

            service.AddSubscriber(Steve1);
            service.AddSubscriber(John1);

            service.NotifySubscriber();

            service.RemoveSubscriber(Steve1);
            service.NotifySubscriber();

            Console.Read();
        }
    }
}
