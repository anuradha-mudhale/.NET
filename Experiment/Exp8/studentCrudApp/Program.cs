using System;
using System.Linq;
using StudentCRUDApp.Data;
using StudentCRUDApp.Models;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // CREATE
            var student = new Student
            {
                Name = "Anuradha",
                Age = 18,
                Course = "IT"
            };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student Added!");

            // READ
            var students = context.Students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name}");
            }

            // UPDATE
            var firstStudent = context.Students.FirstOrDefault();
            if (firstStudent != null)
            {
                firstStudent.Name = "Updated Anuradha";
                context.SaveChanges();
                Console.WriteLine("Student Updated!");
            }

            // DELETE
            var deleteStudent = context.Students.FirstOrDefault();
            if (deleteStudent != null)
            {
                context.Students.Remove(deleteStudent);
                context.SaveChanges();
                Console.WriteLine("Student Deleted!");
            }
        }
    }
}
