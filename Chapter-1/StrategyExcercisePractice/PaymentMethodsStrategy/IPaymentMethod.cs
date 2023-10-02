using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethodsStrategy
{
    // separate the payment method which varies
    public interface IPaymentMethod
    {
        void ProccessPayment(User user);
    }
}
