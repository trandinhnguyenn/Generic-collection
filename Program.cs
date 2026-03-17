using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<int> numbers = new List<int>();
        Console.WriteLine("Vui long nhap 5 so nguyen:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Du lieu khong hop le! Vui long nhap lai mot so nguyen.");
                i--;
            }
            Console.WriteLine("\nCac phan tu trong danh sach la:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}