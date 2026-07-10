using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Email
{
    public class YahooProvider : IEmailProvider
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Send yahoo Email with content {message} to user\n");
        }
    }
}
