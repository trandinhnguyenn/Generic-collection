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
        Console.WriteLine("--- Danh sach ban dau ---");
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id} \t| Ten: {s.Name}");
        }
        Console.Write("\nNhap ID sinh vien can xoa: ");
        if (int.TryParse(Console.ReadLine(), out int idToRemove))
        {
            int removedCount = students.RemoveAll(s => s.Id == idToRemove);

            if (removedCount > 0)
            {
                Console.WriteLine($"-> Da xoa thanh cong sinh vien co ID {idToRemove}!");
            }
            else
            {
                Console.WriteLine($"-> Khong tim thay sinh vien nao co ID {idToRemove}.");
            }
            Console.WriteLine("\n--- Danh sach sau khi cap nhat ---");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id} \t| Ten: {s.Name}");
            }
        }
        else
        {
            Console.WriteLine("ID nhap vao khong hop le!");
        }
    }
}