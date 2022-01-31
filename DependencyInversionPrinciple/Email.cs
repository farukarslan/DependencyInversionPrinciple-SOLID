using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Email : IMessage
    {
        public string ToAdress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("New mail is arrived.");
            Console.WriteLine("From: " + ToAdress + " Subject: " + Subject + " Content: " + Content);
        }
    }
}
