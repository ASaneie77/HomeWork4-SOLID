using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GoodPractice
{
    public class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending email to {email}...");
        }
    }
}
