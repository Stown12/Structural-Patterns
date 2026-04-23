namespace Structural_patterns.FlyWeight.FactoriesFlyWeight;

public class OakFlyweightCreator
{
    private static TreeFlyweight _flyWeight;
    private OakFlyweightCreator(){}
    public static TreeFlyweight CreateFlyweight()
    {
        if (_flyWeight == null) _flyWeight = new TreeFlyweight("Oak", "Green", "Rough");
        return _flyWeight;
    }
}
public class PineFlyweightCreator
{
    private static TreeFlyweight _flyWeight;
    private PineFlyweightCreator() {}
    public static TreeFlyweight CreateFlyweight()
    {
        if (_flyWeight == null) _flyWeight = new TreeFlyweight("Pine", "strong green", "Peeling");
        return _flyWeight;
    }
}
public class BirchFlyweightCreator
{
    private static TreeFlyweight _flyWeight;
    private BirchFlyweightCreator() {}
    public static TreeFlyweight CreateFlyweight()
    {
        if (_flyWeight == null) _flyWeight = new TreeFlyweight("Birch", "Green", "Smooth");
        return _flyWeight;
    }
}