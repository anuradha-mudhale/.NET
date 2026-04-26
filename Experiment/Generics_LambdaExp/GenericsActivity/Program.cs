// using System;

// class Box<T>  //Example1
// {
//     public T Value;

//     public void Show()
//     {
//         Console.WriteLine(Value);
//     }
// }

// class Program
// {
//     static void PrintData<T>(T data) //Example2
//     {
//         Console.WriteLine(data);
//     }

//     static void Main()
//     {
//         // Generic Class
//         Box<int> intBox = new Box<int>();
//         intBox.Value = 10;
//         intBox.Show();

//         Box<string> strBox = new Box<string>();
//         strBox.Value = "Hello";
//         strBox.Show();

//         // Generic Method
//         PrintData<int>(100);
//         PrintData<string>("Anuradha");
//     }
// }


//2.	Real time use of generics 
/*
Generics are widely used in real-world applications to make code reusable, flexible, and type-safe.

🔹 1. Collections (Most common use)

👉 In C#, collections like:

List<T>
Dictionary<TKey, TValue>
Example:
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);

List<string> names = new List<string>();
names.Add("Anuradha");

👉 Use:
Used in apps to store and manage data like:

student lists
product lists
user data
🔹 2. Database / Repository Pattern

👉 Generics are used to create common database methods

Example:
public class Repository<T>
{
    public void Add(T item)
    {
        // save item to database
    }
}

👉 Use:
Same code works for:

Student data
Employee data
Product data
🔹 3. API Response Handling

👉 Generics are used to return different types of responses

Example:
public class ApiResponse<T>
{
    public T Data { get; set; }
    public string Message { get; set; }
}

👉 Use:

Returning data from Web APIs
Handling success/error responses
🔹 4. Sorting and Searching Algorithms

👉 Generic methods are used for:

sorting
searching
Example:
void Print<T>(T value)
{
    Console.WriteLine(value);
}

👉 Use:
Works for any data type (int, string, object)

🔥 Final One-line Answer (Exam)

👉
Generics are used in real-time applications such as collections, database operations, API responses, and reusable methods to improve code reusability, flexibility, and type safety.
*/

//3.	Why companies use generics
//Companies use generics to write reusable code that works with multiple data types, reducing duplication.
//They also provide type safety, which helps catch errors at compile time and improves performance.