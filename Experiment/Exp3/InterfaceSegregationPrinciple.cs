using System;

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Manager : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Manager is working");
    }

    public void Eat()
    {
        Console.WriteLine("Manager is eating");
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working");
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.Work();
        m.Eat();

        Robot r = new Robot();
        r.Work();
    }
}
