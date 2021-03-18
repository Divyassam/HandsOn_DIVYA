using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPgm
{
    public abstract class Subject
    {
        public abstract void Attach(Observer o);
        public abstract void Detach(Observer o);
        public abstract void Notify(Message m);
    }

    public class MessagePublisher : Subject
    {
        State state = new State();
        
        private List<Observer> observers = new List<Observer>();
       

        //Add New Observer
        public override void Attach(Observer o)
        {
            observers.Add(o);
        }


        //Remove Observer
        public override void Detach(Observer o)
        {
            observers.Remove(o);
        }


        //Notify all observers
        public override void Notify(Message m)
        {
            foreach(Observer o in observers)
            {
                o.Update(m);
            }
        }

        //Change State of Publisher
        public void ChangeState()
        {
            if (state.CurrentState) state.CurrentState = false;
            else state.CurrentState = true;
            state.Count++;
            Notify(new Message("Publisher's State changed - " + state.Count + " times"));
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}
