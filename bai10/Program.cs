using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu muon them vao danh sach: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    numbers.Add(val);
                }
            }
            if (numbers.Count > 0)
            {
                int minVal = numbers.Min();

                Console.WriteLine("\nDanh sach ban vua nhap: " + string.Join(", ", numbers));
                Console.WriteLine($"Gia tri nho nhat trong danh sach la: {minVal}");
            }
        }
        else
        {
            Console.WriteLine("So luong khong hop le!");
        }
    }
}