namespace Structural_patterns.Bridge;

public class EmailSender: INotificationSender
{
    
    public string Type { get; set; }

    public EmailSender()
    {
        Type = "Email";
    }
   
}

public class SmsSender: INotificationSender
{
    public string Type { get; set; }
    public SmsSender()
    {
        Type = "SMS";
    }
   
}

public class AlertNotification: Notification
{
    private INotificationSender _sender;
    public AlertNotification(INotificationSender sender)
    {
        _sender = sender;
    }

    public void Send(string message)
    {
        Console.WriteLine("===== Sending alert notification... =====");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Using: {_sender.Type}");
        
    }

    public void SetSender(INotificationSender sender)
    {
        _sender = sender;
    }
}

public class ReminderNotification: Notification
{
    private INotificationSender _sender;
    public ReminderNotification(INotificationSender sender)
    {
        _sender = sender;
    }

    public void Send(string message)
    {
        Console.WriteLine("===== Sending Reminder notification... =====");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Using: {_sender.Type}");
        
    }

    public void SetSender(INotificationSender sender)
    {
        _sender = sender;
    }
}