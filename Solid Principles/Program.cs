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
            int[] monthsDays = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int result = 0;
            monthsDays[1] = int.Parse(inputArray[0]) % 4 == 0 ? 29 : 28;

            for (int i = 0; i < int.Parse(inputArray[1]); i++)
            {
                if (i == int.Parse(inputArray[1]) - 1)
                {
                    result = result + int.Parse(inputArray[2]);
                    break;
                }
                result = result + monthsDays[i];
            }
            return result;
        }
    }
}
