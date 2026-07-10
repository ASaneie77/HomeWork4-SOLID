using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Email
{
    public interface IEmailProvider
    {
        void SendEmail(string message);
    }
}
