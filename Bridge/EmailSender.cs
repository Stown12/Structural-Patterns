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
    public AlertNotification(INotificationSender sender)
        :base(sender){}

    public override void Send(string message)
    {
        Console.WriteLine("===== Sending alert notification... =====");
        base.Send(message);
    }

}

public class ReminderNotification: Notification
{
    public ReminderNotification(INotificationSender sender):
        base(sender){}

    public override void Send(string message)
    {
        Console.WriteLine("===== Sending Reminder notification... =====");
        base.Send(message);
    }
}