// Create a context
using strategy;

var paymentContext = new PaymentContext();

// Use Credit Card payment strategy
paymentContext.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432", "John Doe"));
paymentContext.ExecutePayment(100.00m);

Console.WriteLine();

// Use PayPal payment strategy
paymentContext.SetPaymentStrategy(new PayPalPayment("john.doe@example.com"));
paymentContext.ExecutePayment(150.50m);

Console.WriteLine();

// Use Bitcoin payment strategy
paymentContext.SetPaymentStrategy(new BitcoinPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"));
paymentContext.ExecutePayment(200.75m);
