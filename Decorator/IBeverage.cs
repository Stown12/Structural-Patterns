namespace Structural_patterns.Decorator;

//Component
public interface IBeverage
{
    string GetDescription();
    decimal GetCost();
}

//Decorator asbtracto
public abstract class BeverageDecorator: IBeverage
{
    protected IBeverage _beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual string GetDescription() => _beverage.GetDescription();

    public virtual decimal GetCost() => _beverage.GetCost();
}