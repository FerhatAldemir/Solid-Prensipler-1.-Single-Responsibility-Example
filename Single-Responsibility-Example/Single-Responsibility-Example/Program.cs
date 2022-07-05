using Single_Responsibility_Example.Absraction;
using Single_Responsibility_Example.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ISenderService SenderService = new SenderManager(new MailSend() {TextMessage = "Merhaba",To="frtaldemir@hotmail.com" });
            SenderService.Send();

            SenderService = new SenderManager(new SmsSend() { TextMessage = "Merhaba", To = "05428228574" });
            SenderService.Send();
            Console.ReadLine();
        }
    }
}
