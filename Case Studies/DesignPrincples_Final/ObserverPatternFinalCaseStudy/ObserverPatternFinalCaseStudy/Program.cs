using System;

namespace ObserverPatternFinalCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminTeamObserver Steve1 = new SteveObserver();
            AdminTeamObserver John1 = new JohnObserver();
            INotificationService service = new NotificationService();
            
            service.AddSubscriber(Steve1);
            service.AddSubscriber(John1);
            new Event("Disco", 1200, service);
            new Event("Recitaion", 13,service);

            service.RemoveSubscriber(Steve1);
            new Event("Fashion Show", 400,service);

            Console.Read();
        }
    }
}
