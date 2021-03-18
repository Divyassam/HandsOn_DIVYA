using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPgm
{
    public interface IUser
    {
        public void ReceiveMessage(string msg);
        public void SendMessage(string msg);
    }

    public class BasicUser : IUser
    {
        IChatMediator _chatMediator;
        string Name { get; set; }
        public BasicUser(IChatMediator chatMediator,string name)
        {
            _chatMediator = chatMediator;
            Name = name;
        }
        public void ReceiveMessage(string msg)
        {
            Console.WriteLine($"{Name}-Recieved : {msg}");
        }
        public void SendMessage(string msg)
        {
            Console.WriteLine($"{Name}-Sent : {msg}\n----------------------");
            _chatMediator.SendMessage(this, msg);
           
        }
    }

    public class PremiumUser : IUser
    {
        IChatMediator _chatMediator;
        string Name { get; set; }
        public PremiumUser(IChatMediator chatMediator, string name)
        {
            _chatMediator = chatMediator;
            Name = name;
        }
        public void ReceiveMessage(string msg)
        {
            Console.WriteLine($"{Name}-Recieved : {msg}");
        }
        public void SendMessage(string msg)
        {
            _chatMediator.SendMessage(this, msg);
            Console.WriteLine($"{Name}-Sent : {msg}");
        }
    }
}
