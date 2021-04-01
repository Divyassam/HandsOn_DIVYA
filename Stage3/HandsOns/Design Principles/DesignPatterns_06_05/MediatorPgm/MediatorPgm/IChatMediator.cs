using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPgm
{
    //Mediator
    public interface IChatMediator
    {
        public void AddUser(IUser user);
        public void SendMessage(IUser sender,string msg);
    }


    //Concrete mediator
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;
        public ChatMediator()
        {
            users = new List<IUser>();
        }
        public void AddUser(IUser user)
        {
            users.Add(user);
        }
        public void SendMessage(IUser sender, string msg)
        {
            foreach(var i in users)
            {
                if (i != sender)
                {
                    i.ReceiveMessage(msg);
                }
            }
        }
    }
}
