using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class ChatMessage 
    {
        private string messageId;
        private string content;
        private DateTime timestamped;
        private string channel;
        private Character sender;

        public ChatMessage(string messageId, string content, DateTime timestamped, string channel, Character sender)
        {
            this.messageId = messageId;
            this.content = content;
            this.timestamped = timestamped;
            this.channel = channel;
            this.sender = sender;
        }

        public void Send()
        {
            
        }
    }
}
