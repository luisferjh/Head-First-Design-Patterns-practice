using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethodsStrategy
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProccessPayment(User user)
        {
            Console.WriteLine($"proccesing payment of {user.Name} with Credit card to pay the amount {user.Amount}");
        }
    }
}
