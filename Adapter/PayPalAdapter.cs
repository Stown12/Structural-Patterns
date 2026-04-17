namespace Structural_patterns.Adapter;

public class PayPalAdapter: IPaymentProcessor
{
    private PayPalService _payPalService;

    public PayPalAdapter(PayPalService payPalService)
    {
        _payPalService = payPalService;
    }
    public void ProcessPayment(decimal amount)
    {
        var amountDouble = Convert.ToDouble(amount);
        _payPalService.SendMoney("USD", amountDouble);
    }
}