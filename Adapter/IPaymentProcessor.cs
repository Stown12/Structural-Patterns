namespace Structural_patterns.Adapter;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}