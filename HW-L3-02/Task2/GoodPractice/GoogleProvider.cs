using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.GoodPractice
{
    public class GoogleProvider : IEmailProvider
    {
        public void SendEmail()
        {
            Console.WriteLine("Send Email via Google\n");
        }
    }
}
