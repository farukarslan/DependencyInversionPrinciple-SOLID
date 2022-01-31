using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Whatsapp : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string Emoji { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("New whatsapp message is arrived.");
            Console.WriteLine("From: " + PhoneNumber + " Message: " + Message + " Emoji: " + Emoji);
        }
    }
}
