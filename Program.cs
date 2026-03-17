using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<int> numbers = new List<int>();
        Console.Write("Ban muon nhap bao nhieu so nguyen? ");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            for (int i = 0; i < count; i++)
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
            }
            int sum = numbers.Sum();
            Console.WriteLine($"\nDanh sach ban vua nhap: {string.Join(", ", numbers)}");
            Console.WriteLine($"Tong cac phan tu trong danh sach la: {sum}");

        }
        else
        {
            Console.WriteLine("So luong khong hop le. Vui long chay lai chuong trinh!");
        }
    }
}