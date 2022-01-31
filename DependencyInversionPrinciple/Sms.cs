using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("New sms is arrived.");
            Console.WriteLine("From: " + PhoneNumber + " Content: " + Message);
        }
    }
}
