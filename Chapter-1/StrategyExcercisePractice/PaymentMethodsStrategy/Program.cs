namespace PaymentMethodsStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment Gateway System");

            Console.WriteLine("Insert your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Insert your phone number:");
            string phone = Console.ReadLine();
            Console.WriteLine("Insert total amount to pay:");
            decimal amout = decimal.Parse(Console.ReadLine());

            User user = new User()
            { 
                Name = name,
                Email = email,
                PhoneNumber = phone,
                Amount = amout
            };

            Console.WriteLine("Select payment method");
            Console.WriteLine("1: Paypal");
            Console.WriteLine("2: Credit card");
            Console.WriteLine("3: Bank transfer");
            int option = int.Parse(Console.ReadLine());
            IPaymentMethod paymentMethod;

            switch (option)
            {
                case 1:
                    paymentMethod = new PaypalPayment();             
                    break;
                case 2:
                    paymentMethod = new CreditCardPayment();
                    break;
                case 3:
                    paymentMethod = new BankTransferPayment();
                    break;
                default:
                    paymentMethod = new BankTransferPayment();
                    break;
            }

            paymentMethod.ProccessPayment(user);
        }
    }
}