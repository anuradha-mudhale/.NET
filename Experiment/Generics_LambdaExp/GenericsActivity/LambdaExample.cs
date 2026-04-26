using System;

class LambdaExamples
{
    static void Main()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));

        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(3, 4));
    }
}

/*✅ 2. Where lambda expressions are used in companies

👉 Lambda expressions are used in:

LINQ queries (filtering, sorting data)
Event handling (button click, UI actions)
Collections processing (List filtering, searching)
Functional programming (clean and short code)

👉 Real example:

var evenNumbers = numbers.Where(n => n % 2 == 0);*/


/*3. Generic class using Lambda Expression*/

// using System;

// class Box<T>
// {
//     public T Value1;
//     public T Value2;

//     public void Show()
//     {
//         Console.WriteLine(Value1 + " " + Value2);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Box<int> obj = new Box<int>();

//         // Lambda expression to assign values
//         Action<int, int> setValues = (a, b) =>
//         {
//             obj.Value1 = a;
//             obj.Value2 = b;
//         };

//         setValues(10, 20);
//         obj.Show();   // Output: 10 20
//     }
// }