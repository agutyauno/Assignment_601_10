namespace Assignment_601_10.payment;

internal class EWalletPayment : IPaymentStrategy
{
    public bool Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using E-Wallet.");
        return true;
    }
}
