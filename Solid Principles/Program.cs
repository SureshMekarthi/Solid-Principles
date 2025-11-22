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
           UserRegisterService userRegisterService = new UserRegisterService();
            userRegisterService.RegisterUser("test@example.com");
            Console.ReadLine(); 

        }
    }
}
