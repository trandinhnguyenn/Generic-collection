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
            new Student { Id = 1, Name = "Nguyen Van An" },
            new Student { Id = 2, Name = "Tran Thi Binh" },
            new Student { Id = 3, Name = "Le Van Cuong" }
        };
        Console.Write("Nhap ten sinh vien can tim: ");
        string searchName = Console.ReadLine();
        bool found = false;
        Console.WriteLine("\n--- Ket qua tim kiem ---");
        foreach (Student s in students)
        {
            if (s.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Tim thay: ID = {s.Id} | Name = {s.Name}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Khong tim thay sinh vien nao co ten '{searchName}'.");
        }
    }
}