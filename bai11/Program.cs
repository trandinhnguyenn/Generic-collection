using System;
using System.Collections.Generic;
class Student
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<Student> students = new List<Student> {
            new Student { Id = 1, Name = "Nguyen Van A" },
            new Student { Id = 2, Name = "Tran Thi B" },
            new Student { Id = 3, Name = "Le Van C" }
        };
        Console.WriteLine("--- Thong tin danh sach sinh vien ---");
        foreach (Student s in students)
        {
            Console.WriteLine($"ID: {s.Id} \t| Name: {s.Name}");
        }
    }
}