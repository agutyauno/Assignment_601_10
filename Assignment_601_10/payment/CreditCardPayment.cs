namespace Assignment_601_10.payment;

internal class CreditCardPayment : IPaymentStrategy
{
    public bool Pay(double amount)
    {
        // Logic for credit card payment
        Console.WriteLine($"Paid {amount} using Credit Card.");
        return true;
    }
}
