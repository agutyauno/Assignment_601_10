namespace Assignment_601_10.payment;

internal class CashPayMent : IPaymentStrategy
{
    public bool Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Cash.");
        return true;
    }
}
