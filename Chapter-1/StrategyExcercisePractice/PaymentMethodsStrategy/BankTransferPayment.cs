using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethodsStrategy
{
    public class BankTransferPayment : IPaymentMethod
    {
        public void ProccessPayment(User user)
        {
            Console.WriteLine($"proccesing payment of {user.Name} with bank transfer to pay the amount {user.Amount}");
        }
    }
}
