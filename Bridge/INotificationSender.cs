namespace Structural_patterns.Bridge;

public interface INotificationSender
{
    string Type { get; set; }
}

public interface Notification
{
    void Send(string message);
    void SetSender(INotificationSender sender);
}