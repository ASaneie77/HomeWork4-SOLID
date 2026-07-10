using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BadPractice
{
    public class UserService
    {
        public void RegisterUser(string username, string email)
        {
            Console.WriteLine($"Registering user: {username}");

            SaveToDatabase(username, email);

            SendEmail(email);
        }

        private void SaveToDatabase(string username, string email)
        {
            Console.WriteLine("Saving user to Database...");
        }

        private void SendEmail(string email)
        {
            Console.WriteLine($"Sending email to {email}...");
        }
    }

}
