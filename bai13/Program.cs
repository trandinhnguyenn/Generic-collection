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
        List<Student> students = new List<Student>();
        Console.Write("Ban muon nhap bao nhieu sinh vien? ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap sinh vien thu {i + 1} ---");

                Console.Write("Nhap ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nhap Ten: ");
                string name = Console.ReadLine();
                students.Add(new Student { Id = id, Name = name });
            }
            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine($"Tong so sinh vien trong danh sach la: {students.Count}");
        }
        else
        {
            Console.WriteLine("So luong khong hop le, vui long nhap so lon hon 0!");
        }
    }
}