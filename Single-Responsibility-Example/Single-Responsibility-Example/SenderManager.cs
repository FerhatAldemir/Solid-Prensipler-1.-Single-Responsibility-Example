using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Example
{
    public class SenderManager : ISenderService
    {
        public Message message { get; set; } 

        public SenderManager(Message _message)
        {
            message = _message;
        }
        public void Send()
        {
            message.Send();
        }

      
    }
}
