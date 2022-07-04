using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Example
{
    public class SmsSend : Message
    {
        public override string To { get; set; }
        public override string TextMessage { get; set; }

        public override bool Send()
        {
            Console.Write(To + "Numarasına Sms Gönderilemedi");

            return false;
        }
    }
}
