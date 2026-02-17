using System;

class Student
{
    // Private data members (Encapsulation)
    private string name;
    private int age;

    // Public method to set values
    public void SetData(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to display values
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        // Creating object
        Student s1 = new Student();

        // Accessing methods
        s1.SetData("Anuradha", 20);
        s1.Display();
    }
}
