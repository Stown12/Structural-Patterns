

using Structural_patterns.Composite;
using Structural_patterns.Decorator;
using Structural_patterns.Facade;
using File = Structural_patterns.Composite.File;

class Program
{
    public static void Main(string[] args)
    {
        SmartHomeFacade smartHome = new SmartHomeFacade(new Lights(), new AirConditioner(), new SecuritySystem());
        Console.WriteLine("Leaving home:");
        smartHome.LeaveHome();
        Console.WriteLine("\nArriving home:");
        smartHome.ArriveHome();
    }
}
