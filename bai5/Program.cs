using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<string> students = new List<string> { "An", "Binh", "Cuong", "Dung", "Hoa" };

        Console.WriteLine("Danh sach hien tai: " + string.Join(", ", students));

        Console.Write("Nhap ten sinh viên muon xoa: ");
        string nameToRemove = Console.ReadLine();
        if (students.Remove(nameToRemove))
        {
            Console.WriteLine($"Da xoa thanh cong ten '{nameToRemove}'!");
        }
        else
        {
            Console.WriteLine($"Khong tim thay ten '{nameToRemove}' trong danh sach.");
        }
        Console.WriteLine("\nDanh sach sau khi cap nhat: " + string.Join(", ", students));
    }
}