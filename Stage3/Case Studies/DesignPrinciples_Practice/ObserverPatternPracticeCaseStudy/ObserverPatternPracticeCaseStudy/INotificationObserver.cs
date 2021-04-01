using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPracticeCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }
        void OnServerDown();
    }

    //Concrete Observer 1
    public class SteveObserver : INotificationObserver
    {
        public string Name{ get { return "Steve"; } }
       
        public void OnServerDown()
        {
            Console.WriteLine(Name + " Notification Recieved");
        }
    }


    //Concrete Observer 2
    public class JohnObserver : INotificationObserver
    {
        public string Name { get { return "John"; } }
       
        public void OnServerDown()
        {
            Console.WriteLine(Name + " Notification Recieved");
        }
    }
}
