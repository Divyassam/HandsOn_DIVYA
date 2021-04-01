using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPgm
{
    public class Message
    {
        readonly string messageContent;
        public Message(String m) 
        { 
            messageContent = m; 
        }
        public String getMessageContent()
        { 
            return messageContent;
        }
    }
}
