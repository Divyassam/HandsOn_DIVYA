using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public interface AdminTeamObserver
    {
        string Name { get; }
        void OnNotify(Event events);
    }

    //Concrete Observer 1
    public class SteveObserver : AdminTeamObserver
    {
        public string Name { get { return "Steve"; } }

        public void OnNotify(Event events)
        {
            Console.WriteLine(Name + " notified for "+events.Name);
        }
    }


    //Concrete Observer 2
    public class JohnObserver : AdminTeamObserver
    {
        public string Name { get { return "John"; } }

        public void OnNotify(Event events)
        {
            Console.WriteLine(Name + " notified for " + events.Name);
        }
    }
}
