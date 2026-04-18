namespace Structural_patterns.Decorator;

//Concrete Component
public class Coffe: IBeverage
{
    
    private decimal _cost = 1.00m;
    private string _description = "Coffe,";
    public string GetDescription() => _description;

    public decimal GetCost() => _cost;
}

//Concrete Decorators
public class Milk: BeverageDecorator
{
    public Milk(IBeverage beverage) : base(beverage)
    { 
    }
    
    public override decimal GetCost() => _beverage.GetCost() + 0.20m;

    public override string GetDescription() => _beverage.GetDescription() + " Milk,";
}

public class Sugar: BeverageDecorator
{
    public Sugar(IBeverage beverage) : base(beverage)
    { 
    }
    
    public override decimal GetCost() => _beverage.GetCost() + 0.20m;

    public override string GetDescription() => _beverage.GetDescription() + " Sugar,";
}

public class Vanilla: BeverageDecorator
{
    public Vanilla(IBeverage beverage) : base(beverage)
    { 
    }
    
    public override decimal GetCost() => _beverage.GetCost() + 0.20m;

    public override string GetDescription() => _beverage.GetDescription() + " Vanilla,";
}