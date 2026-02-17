using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

class SMS : IMessage
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}

class Notification
{
    private IMessage message;

    public Notification(IMessage msg)
    {
        message = msg;
    }

    public void Notify()
    {
        message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage msg = new Email();   // Can change to SMS
        Notification n = new Notification(msg);
        n.Notify();
    }
}
