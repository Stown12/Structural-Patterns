namespace Structural_patterns.Bridge;

public interface INotificationSender
{
    string Type { get; set; }
}

public abstract class Notification
{
    protected INotificationSender _sender;
    public Notification(INotificationSender sender)
    {
        _sender = sender;
    }

    public virtual void Send(string message)
    {
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Using: {_sender.Type}");
    }

    public void SetSender(INotificationSender sender)
    {
        _sender = sender;
    }
}
