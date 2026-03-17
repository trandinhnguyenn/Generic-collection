using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        Console.Write("Nhap mot chuoi bat ky (VD: hello): ");
        string input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }
        Console.WriteLine("\nKet qua:");
        foreach (var item in charCount)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}