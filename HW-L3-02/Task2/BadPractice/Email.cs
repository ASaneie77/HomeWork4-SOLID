using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BadPractice
{
    public class Email
    {
        public void SendEmail(EmailProvider provider)
        {
            if(provider == EmailProvider.yahoo_provider)
            {
                Console.WriteLine("Send Email via Yahoo\n");
            }
            else if (provider == EmailProvider.google_provider)
            {
                Console.WriteLine("Send Email via Google\n");
            }

        }
    }

    public enum EmailProvider
    {
        yahoo_provider,
        google_provider
    }
}
