using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Content = "This is a test mail.";
            email.Subject = "TEST";
            email.ToAdress = "test@gmail.com";

            Sms sms = new Sms();
            sms.Message = "This is a test message.";
            sms.PhoneNumber = "5349668329";

            List<IMessage> notifications = new List<IMessage> { email, sms };
            Notification notification = new Notification(notifications);
            notification.Send();

            Console.Read();

        }
    }
}
