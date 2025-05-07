namespace Assignment_601_10.payment;

internal class Payment
{
    double amount;
    string status;
    IPaymentStrategy? paymentStrategy;

    public Payment(double amount, string status)
    {
        this.amount = amount;
        this.status = status;
    }

    public double Amount { get => amount; set => amount = value; }
    public string Status { get => status; set => status = value; }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public bool ProcessPayment()
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("Chua chon phuong thuc thanh toan.");
            return false;
        }
        bool success = paymentStrategy.Pay(Amount);
        if (success)
        {
            Status = "Đa thanh toan";
        }
        else
        {
            status = "Thanh toan that bai";
        }
        return success;
    }
}
