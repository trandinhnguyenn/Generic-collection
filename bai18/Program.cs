using System;
using System.Collections.Generic;
class Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<Student> students = new List<Student> {
            new Student { Name = "Nguyen Van An", Score = 8.5 },
            new Student { Name = "Tran Thi Binh", Score = 9.8 },
            new Student { Name = "Le Van Cuong", Score = 7.2 },
            new Student { Name = "Hoang Thi Dung", Score = 9.8 }
        };
        Console.WriteLine("--- DANH SACH SINH VIEN ---");
        foreach (var s in students)
        {
            Console.WriteLine($"Ten: {s.Name} \t| Diem: {s.Score}");
        }
        double maxScore = 0;
        foreach (var s in students)
        {
            if (s.Score > maxScore)
            {
                maxScore = s.Score;
            }
        }
        Console.WriteLine("\n--- SINH VIEN CO DIEM CAO NHAT ---");
        foreach (var s in students)
        {
            if (s.Score == maxScore)
            {
                Console.WriteLine($"=> Thu khoa: {s.Name} voi {s.Score} diem.");
            }
        }
    }
}
