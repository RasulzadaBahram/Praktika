using Interface.Interface;

namespace Interface.Models
{
    class CashPayment : IPayment
    {

        public void Pay(double amount)
        {
            Console.WriteLine("Vergi 0 \n" );
        }
    }
}


