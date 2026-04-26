//delegates
//1. Calculator using Delegate (+, -, *, /)
// using System;

// delegate int Calculator(int a, int b);

// class Program
// {
//     static int Add(int a, int b) => a + b;
//     static int Sub(int a, int b) => a - b;
//     static int Mul(int a, int b) => a * b;
//     static int Div(int a, int b) => a / b;

//     static void Main()
//     {
//         Calculator calc;

//         calc = Add;
//         Console.WriteLine("Add: " + calc(10, 5));

//         calc = Sub;
//         Console.WriteLine("Sub: " + calc(10, 5));

//         calc = Mul;
//         Console.WriteLine("Mul: " + calc(10, 5));

//         calc = Div;
//         Console.WriteLine("Div: " + calc(10, 5));
//     }
// }


//Multicast Deligates
using System;

delegate void ShowMessage();

class Program
{
    static void Hello() => Console.WriteLine("Hello");
    static void Welcome() => Console.WriteLine("Welcome");

    static void Main()
    {
        ShowMessage msg;

        msg = Hello;
        msg += Welcome;   // Multicast

        msg();
    }
}

//3. Replace Method with Lambda Expression
// using System;

// class Program
// {
//     static void Main()
//     {
//         Func<int, int, int> add = (a, b) => a + b;

//         Console.WriteLine(add(5, 3));
//     }
// }

//4. Sort List using Lambda Expression
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

//         numbers.Sort((a, b) => a.CompareTo(b));

//         foreach (var n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }


// 5. Where Delegate and Lambda are used in Company Level

// 👉 Used in:

// Event handling (button click, UI actions)
// LINQ queries (filtering, sorting data)
// Asynchronous programming (Task, async/await)
// Collections processing
// Backend APIs (data transformation)

// 👉 They help to write:

// Clean code
// Less code
// Reusable logic

// 6. What are LINQ Queries
// 🔸 Definition:

// LINQ (Language Integrated Query) is used to query and manipulate data in C# like SQL.