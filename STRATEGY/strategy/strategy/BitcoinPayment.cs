using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    internal class BitcoinPayment : IPaymentStrategy
    {
        private string _walletAddress;

        public BitcoinPayment(string walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Bitcoin. Wallet Address: {_walletAddress}");
        }
    }
}
