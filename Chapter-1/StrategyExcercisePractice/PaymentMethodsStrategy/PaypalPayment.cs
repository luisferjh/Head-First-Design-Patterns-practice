using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethodsStrategy
{
    public class PaypalPayment : IPaymentMethod
    {
        public void ProccessPayment(User user)
        {
            Console.WriteLine($"proccesing payment of {user.Name} with Paypal platform to pay the amount {user.Amount}");
        }
    }
}
