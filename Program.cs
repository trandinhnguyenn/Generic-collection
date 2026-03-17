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
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le, vui long nhap lai!");
                    i--;
                }
            }

            int max = numbers.Max();
            Console.WriteLine($"\nDanh sach: {string.Join(", ", numbers)}");
            Console.WriteLine($"So lon nhat la: {max}");
        }
    }
}