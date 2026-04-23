namespace Structural_patterns.FlyWeight;

public class TreeFlyweight
{
    public string Type { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeFlyweight(string type, string color, string texture)
    {
        Type = type;
        Color = color;
        Texture = texture;
    }
    
    public void Render(int x, int y)
    {
        Console.WriteLine($"Rendering {Type} tree at ({x},{y}) | Color: {Color} | Texture: {Texture}");
    }
}

public class Tree
{
    private int _x;
    private int _y;
    private TreeFlyweight _flyweight;

    public Tree(int x, int y, TreeFlyweight flyweight)
    {
        _x = x;
        _y = y;
        _flyweight = flyweight;
    }
    public void Render() => _flyweight.Render(_x, _y);
}