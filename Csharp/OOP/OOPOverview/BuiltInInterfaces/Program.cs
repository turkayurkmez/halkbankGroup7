// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");

Student student1 = new Student { Id = 1, Name = "Türkay", LastName = "Ürkmez", Age = 42, Score = 3.5 };
Student student2 = new Student { Id = 2, Name = "Erdem", LastName = "Akdeniz", Age = 32, Score = 3.8 };
Student student3 = new Student { Id = 3, Name = "Remziye", LastName = "Akgün", Age = 25, Score = 4.0 };

StudentCollection studentCollection = new StudentCollection();
studentCollection.AddStudents(student1, student2, student3);
studentCollection.SortStudents();

foreach (var student in studentCollection)
{
    Console.WriteLine($"{student.Name}\t{student.LastName}\t{student.Age}\t{student.Score} ");
}