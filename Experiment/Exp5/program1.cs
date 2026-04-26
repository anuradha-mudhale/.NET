//Activity 2
//convert to asynchronous
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Console.ReadLine();
    }

async static void Task1()
    { 
        await Task.Run(()=>{
            Console.WriteLine("Task 1 started");
            Thread.Sleep(3000);
            Console.WriteLine("Task 1 executed");
        });
       
    }

async static void Task2()
    {
        await Task.Run(()=>{
        Console.WriteLine("Task 2 started");
        Thread.Sleep(2000);
        Console.WriteLine("Task 2 executed");
        });
        
    }

async static void Task3()
    {
        await Task.Run(()=>{
        Console.WriteLine("Task 3 started");
        Thread.Sleep(1000);
        Console.WriteLine("Task 3 executed");
        });
        
    }

async static void Task4()
    {
        await Task.Run(()=>{
        Console.WriteLine("Task 4 started");
        Thread.Sleep(4000);
        Console.WriteLine("Task 4 executed");
        });
       
    }
   
}

//Activity 1:
//run program synchronously
//convert to asynchronous
//replace thread.sleep with the task.delay observe behaviour
//create method and returning task
