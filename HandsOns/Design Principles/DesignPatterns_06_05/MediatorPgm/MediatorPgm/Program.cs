using System;

namespace MediatorPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            IUser Max = new BasicUser(chatMediator, "Max");
            IUser Jiya = new PremiumUser(chatMediator, "Jiya");
            IUser Tim = new BasicUser(chatMediator, "Tim");
            IUser Unknown = new BasicUser(chatMediator, "Unknown");

            chatMediator.AddUser(Max);
            chatMediator.AddUser(Jiya);
            chatMediator.AddUser(Tim);

            Max.SendMessage("Hii");
            Console.WriteLine("\n\n\n");
            Tim.SendMessage("Byee");
            Console.WriteLine("\n\n\n");
            Unknown.SendMessage("I am new User");


        }
    }
}
