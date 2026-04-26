using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // Activity 1: Simple delegate
    public delegate void MyDelegate(string message);

    // Activity 2: Multicast delegate
    public delegate void Notify();

    public static void DisplayMsg(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    public static void MethodA()
    {
        Console.WriteLine("Method A executed");
    }

    public static void MethodB()
    {
        Console.WriteLine("Method B executed");
    }

    public static void Main()
    {
        // Simple delegate
        MyDelegate del = DisplayMsg;
        del("Hello from here");

        // Multicast delegate
        Notify notify = MethodA;
        notify += MethodB;
        notify();
        
        // Lambda expression example
        Notify lambdaNotify = () => Console.WriteLine("Lambda method executed");
        lambdaNotify();

        // Lambda with List sorting
        List<int> numbers = new List<int> { 5, 2, 8, 1 };
        numbers.Sort((a, b) => a.CompareTo(b));

        Console.WriteLine("Sorted List:");
        foreach (int n in numbers)
            Console.WriteLine(n);

        // LINQ example
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        Console.WriteLine("Even Numbers:");
        foreach (var n in evenNumbers)
            Console.WriteLine(n);
    }
}


//Activities:
//replace methods with lambda exression
//sort list using lambda
//where deligates an lambda expression are used 
//what is linq querys 
