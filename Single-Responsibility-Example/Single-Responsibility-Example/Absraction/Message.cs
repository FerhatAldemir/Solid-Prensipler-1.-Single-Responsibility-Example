using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Example.Absraction
{
   public abstract class Message
    {
        public abstract string To { get; set; }
        public abstract string TextMessage { get; set; } 
        public abstract bool Send();
    }
}
