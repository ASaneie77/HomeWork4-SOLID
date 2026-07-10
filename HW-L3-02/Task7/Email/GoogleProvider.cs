using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Email
{
    public class GoogleProvider : IEmailProvider
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Send gmail with content {message} to user\n");
        }
    }
}
