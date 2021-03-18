using System;

namespace ObserverPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();

            p.Attach(s1);
            p.Attach(s2);
            p.ChangeState(); //s1 and s2 will receive the update 

            Console.WriteLine("");
            p.Attach(s3);
            p.ChangeState(); //s1, s2 and s3 will receive the update
            Console.WriteLine("");


            p.Detach(s1);
            p.ChangeState(); //s2 and s3 will receive the update
        }
    }
}
