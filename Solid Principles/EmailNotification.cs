using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class EmailNotification
    {
        public void SendWelcomeEmail(string email)
        {
            Console.WriteLine("Sending welcome email to " + email);
        }
    }
}
