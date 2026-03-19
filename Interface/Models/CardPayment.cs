using Interface.Interface;

namespace Interface.Models
{
    class CardPayment : IPayment
    {
        public void Pay(double amount)
        {

            double edv = (amount * 18) / 100;
            double gelir = amount - edv;

            Console.WriteLine($"{amount}");
            Console.WriteLine($"{gelir}   18% vergi tutuldu");

        }
    }
}
