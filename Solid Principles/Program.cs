using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            try
            {
                userService.RegisterUser("test@example.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
