//Activity1
//run program synchronously
using System;
using System.Threading;


public class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
       
    }

static void Task1()
    { 
      
            Console.WriteLine("Task 1 started");
            Thread.Sleep(3000);
            Console.WriteLine("Task 1 executed");
       
    }

static void Task2()
    {
       
        Console.WriteLine("Task 2 started");
        Thread.Sleep(2000);
        Console.WriteLine("Task 2 executed");
        
        
    }

static void Task3()
    {
        
        Console.WriteLine("Task 3 started");
        Thread.Sleep(1000);
        Console.WriteLine("Task 3 executed");
    
        
    }

static void Task4()
    {
        
        Console.WriteLine("Task 4 started");
        Thread.Sleep(4000);
        Console.WriteLine("Task 4 executed");
       
       
    }
   
}

//Activity 1:
//replace thread.sleep with the task.delay observe behaviour
//create method and returning task
