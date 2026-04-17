
using Structural_patterns.Adapter;
using Structural_patterns.Bridge;

class Program
{
    public static void Main(string[] args)
    {
        INotificationSender email = new EmailSender();
        INotificationSender sms = new SmsSender();

        Notification alert = new AlertNotification(email);
        Notification reminder = new ReminderNotification(sms);
        
        alert.Send("This is an alert notification.");
        reminder.Send("This is a reminder notification.");

        alert.SetSender(sms);
        alert.Send("This is an alert notification.");
    }
}
