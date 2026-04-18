namespace Structural_patterns.Facade;

public class Lights
{
    public void TurnOn() => Console.WriteLine("Lights turned on.");
    public void TurnOff() => Console.WriteLine("Lights turned off.");
}

public class AirConditioner
{
    public void SetTemperature() => Console.WriteLine("Air conditioner temperature set: 22°C.");
    public void TurnOff() => Console.WriteLine("Air conditioner turned off: 18°C.");
}

public class SecuritySystem
{
    public void Arm() => Console.WriteLine("Security system armed.");
    public void Disarm() => Console.WriteLine("Security system disarmed.");
}

public class SmartHomeFacade
{
    private Lights _lights;
    private AirConditioner _airConditioner;
    private SecuritySystem _securitySystem;
    public SmartHomeFacade(Lights lights, AirConditioner airConditioner, SecuritySystem securitySystem)
    {
        _lights = lights;
        _airConditioner = airConditioner;
        _securitySystem = securitySystem;
    }

    public void LeaveHome()
    {
        _lights.TurnOff();
        _airConditioner.TurnOff();
        _securitySystem.Arm();
    }

    public void ArriveHome()
    {
        _lights.TurnOn();
        _airConditioner.SetTemperature();
        _securitySystem.Disarm();
    }
}