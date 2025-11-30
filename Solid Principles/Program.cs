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
            //UserRegisterService userRegisterService = new UserRegisterService();
            // userRegisterService.RegisterUser("test@example.com");
            // Console.ReadLine(); 

            //PaymentService1 paymentService = new PaymentService1();
            //paymentService.ProcessPayment(new CreditCardPayment(), 100);
            //paymentService.ProcessPayment(new PaypalPayment(), 200);

            Console.WriteLine(CalculateDays("2019-02-10"));
            Console.ReadLine();
        }

        public static int CalculateDays(string date)
        {
            string[] inputArray = date.Split('-');


            if (int.Parse(inputArray[0]) % 4 == 0)
            {
                return 366 - (12 - int.Parse(inputArray[1])) * 30 - (30 - int.Parse(inputArray[2]));
            }
            return 365 - (12 - int.Parse(inputArray[1])) * 30 - (30 - int.Parse(inputArray[2]));
        }
    }
}
