using System;
using System.Collections.Generic;
using System.Linq; 
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nDanh sach ban dau: " + string.Join(", ", numbers));
            List<int> distinctNumbers = numbers.Distinct().ToList();
            Console.WriteLine("Danh sach moi (khong trung): " + string.Join(", ", distinctNumbers));
        }
    }
}