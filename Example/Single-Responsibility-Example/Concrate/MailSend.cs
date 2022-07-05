using Single_Responsibility_Example.Absraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Example.Concrate
{
    public class MailSend : Message
    {
        public override string To { get; set; }
        public override string TextMessage { get; set; }

        public override bool Send()
        {
            Console.WriteLine(To + " Adresine Eposta Gönderilmiştir");
            Console.WriteLine("Mesajınız :" + TextMessage);
            return true;
        }
    }
}
