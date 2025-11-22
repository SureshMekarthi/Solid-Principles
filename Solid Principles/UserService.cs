using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class UserService
    {
        //public bool isValidEmail(string email)
        //{
        //  return email.Contains("@");
        //}

        public void RegisterUser(string email)
        {
            if (!email.Contains("@"))
            {
                throw new Exception("Invalid email address");
            }

            // Registration logic here

            Console.WriteLine("User registered successfully.");
            Console.WriteLine("Sending welcome email to " + email);
        }
    }
}
