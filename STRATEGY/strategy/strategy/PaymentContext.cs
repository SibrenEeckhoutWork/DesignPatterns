using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    internal class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        // Sets the payment strategy at runtime
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Executes the payment strategy
        public void ExecutePayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy not set.");
            }

            _paymentStrategy.Pay(amount);
        }
    }
}
