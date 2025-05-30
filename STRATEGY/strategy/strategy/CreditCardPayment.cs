using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    internal class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _cardHolderName;

        public CreditCardPayment(string cardNumber, string cardHolderName)
        {
            _cardNumber = cardNumber;
            _cardHolderName = cardHolderName;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card. Card Holder: {_cardHolderName}, Card Number: {_cardNumber}");
        }
    }
}
