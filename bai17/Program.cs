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
                Console.Write($"Nhap so thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts.Add(num, 1);
                }
            }
            int mostFrequent = numbers[0];
            int maxCount = 0;
            foreach (var item in counts)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    mostFrequent = item.Key; 
                }
            }
            Console.WriteLine("\nDanh sach ban vua nhap: " + string.Join(", ", numbers));
            Console.WriteLine($"-> So xuat hien nhieu nhat la: {mostFrequent} (xuat hien {maxCount} lan)");
        }
        else
        {
            Console.WriteLine("So luong khong hop le!");
        }
    }
}