using System;

interface IShape
{
    double Area();
}

class Rectangle : IShape
{
    public double Area()
    {
        return 5 * 4;
    }
}

class Circle : IShape
{
    public double Area()
    {
        return 3.14 * 3 * 3;
    }
}

class Program
{
    static void Main()
    {
        IShape shape = new Rectangle();
        Console.WriteLine(shape.Area());

        shape = new Circle();
        Console.WriteLine(shape.Area());
    }
}
