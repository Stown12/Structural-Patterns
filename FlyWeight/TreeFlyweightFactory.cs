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
                "Oak"   => new TreeFlyweight("Oak", "Green", "Rough"),
                "Pine"  =>  new TreeFlyweight("Pine", "Strong Green", "Peeling"),
                "Birch" =>  new TreeFlyweight("Birch", "White", "Smooth"),
                _       => throw new ArgumentException($"Unknown tree type: {type}")
            };
            _flyweights[type] = flyweight;
            Console.WriteLine($"[Factory] Created new flyweight: {type}"); 
        }
        return _flyweights[type];
    }
    
    public static int Count() => _flyweights.Count;

}

