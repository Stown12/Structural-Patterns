

using Structural_patterns.Composite;
using Structural_patterns.Decorator;
using Structural_patterns.Facade;
using Structural_patterns.FlyWeight;
using File = Structural_patterns.Composite.File;

class Program
{
    public static void Main(string[] args)
    {
        List<Tree> forest = new();
        Random rand = new Random();

        for (int i = 0; i < 1000; i++)
        {
            string type = i % 3 == 0 ? "Oak" : i % 3 == 1 ? "Pine" : "Birch";
            TreeFlyweight flyweight = TreeFlyweightFactory.GetFlyweight(type);
            forest.Add(new Tree(rand.Next(0, 100), rand.Next(0, 100), flyweight));
        }
        
        Console.WriteLine($"\nÁrboles creados: {forest.Count}");
        Console.WriteLine($"Flyweights en memoria: {TreeFlyweightFactory.Count()}");
    }
}
