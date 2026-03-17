using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            { "hello", "xin chao" },
            { "world", "the gioi" },
            { "computer", "may tinh" },
            { "apple", "qua tao" },
            { "student", "sinh vien" }
        };
        Console.WriteLine("--- TU DIEN ANH - VIET ---");
        Console.WriteLine("Cac tu dang co: hello, world, computer, apple, student\n");
        Console.Write("Nhap tu tieng Anh can tra cuu: ");
        string englishWord = Console.ReadLine();
        if (dict.TryGetValue(englishWord, out string vietnameseMeaning))
        {
            Console.WriteLine($"-> Nghia cua tu '{englishWord}' la: {vietnameseMeaning}");
        }
        else
        {
            Console.WriteLine($"-> Khong tim thay tu '{englishWord}' trong tu dien cua chung toi.");
        }
    }
}