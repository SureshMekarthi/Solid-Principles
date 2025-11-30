using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class PaymentService1
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}
