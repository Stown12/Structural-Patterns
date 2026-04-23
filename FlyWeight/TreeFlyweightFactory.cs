using Structural_patterns.FlyWeight.FactoriesFlyWeight;

namespace Structural_patterns.FlyWeight;

public class TreeFlyweightFactory
{
    private static Dictionary<string, TreeFlyweight> _flyweights = new ();
    

    public static TreeFlyweight GetFlyweight(string type)
    {
        if (!_flyweights.ContainsKey(type))
        {
            var flyweight = type switch
            {
                "Oak"   => OakFlyweightCreator.CreateFlyweight(),
                "Pine"  =>  PineFlyweightCreator.CreateFlyweight(),
                "Birch" =>  BirchFlyweightCreator.CreateFlyweight(),
                _       => throw new ArgumentException($"Unknown tree type: {type}")
            };
            _flyweights[type] = flyweight;
            Console.WriteLine($"[Factory] Created new flyweight: {type}"); 
        }
        return _flyweights[type];
    }
    
    public static int Count() => _flyweights.Count;

}

