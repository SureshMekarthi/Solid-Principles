using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class PaymentService
    {
        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            if (paymentMethod == "CreditCard")
            {
                ProcessCreditCardPayment(amount);
            }
            else if (paymentMethod == "PayPal")
            {
                ProcessPayPalPayment(amount);
            }
            else
            {
                throw new Exception("Unsupported payment method");
            }
        }
        private void ProcessCreditCardPayment(decimal amount)
        {
            Console.WriteLine("Processing credit card payment of " + amount);
        }
        private void ProcessPayPalPayment(decimal amount)
        {
            Console.WriteLine("Processing PayPal payment of " + amount);
        }
    }
}
