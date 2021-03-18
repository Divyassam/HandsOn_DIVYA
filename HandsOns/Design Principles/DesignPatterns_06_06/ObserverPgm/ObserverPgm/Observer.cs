using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPgm
{
    public interface Observer
    {
        public void Update(Message m);
    }


    //Concrete observer 1
    public class MessageSubscriberOne : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());
        }
    }


    //Concrete observer 2
    public class MessageSubscriberTwo : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

        }
    }


    //Concrete observer 3
    public class MessageSubscriberThree : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

        }
    }
}
