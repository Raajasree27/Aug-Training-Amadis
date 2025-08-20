using System;

public class Notification
{
    public virtual void send()
    {
        Console.WriteLine("Send Method is invoked without overriding");
    }
}

public class EmailNotification: Notification
{
    public override void send()
    {
        Console.WriteLine("Sneding the email notification");
    }
}

public class SmsNotification : Notification
{
    public override void send()
    {
        Console.WriteLine("Sneding the sms notification");
    }
}
// Usage
class Program
{
    static void Main(string[] args)
    {
        Notification mail = new EmailNotification();
        Notification sms =new SmsNotification(); 

        Notification noti = new Notification();

        mail.send();
        sms.send();
        noti.send();
    }
}

