
using Structural_patterns.Adapter;

class Program
{
    public static void Main(string[] args)
    {
        var payPalService = new PayPalService();
        var payPalAdapter = new PayPalAdapter(payPalService);
        payPalAdapter.ProcessPayment(99.99m);
    }
}
