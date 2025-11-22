using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class UserRepository
    {
        public void SaveUser(string email)
        {
            // Simulate saving user to a database
            Console.WriteLine("User with email " + email + " saved to the database.");
        }
    }
}
