using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");

        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            // Sắp xếp tăng dần
            numbers.Sort();

            Console.WriteLine("\nDanh sach sau khi sap xep tang dan:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}