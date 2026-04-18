

using Structural_patterns.Composite;
using Structural_patterns.Decorator;
using File = Structural_patterns.Composite.File;

class Program
{
    public static void Main(string[] args)
    {
        IBeverage coffe = new Coffe();
        coffe = new Milk(coffe);
        coffe = new Sugar(coffe);
        coffe = new Vanilla(coffe);
        
        Console.WriteLine($"Description: {coffe.GetDescription()} => ${coffe.GetCost()}");
    }
}
