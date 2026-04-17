namespace Structural_patterns.Adapter;

public class PayPalService
{
    public void SendMoney(string currency, double amount)
    {
        Console.WriteLine($"Paypal: sending... ${amount} {currency}");
    }
}