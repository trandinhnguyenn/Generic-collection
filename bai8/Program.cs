using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");

        List<string> words = new List<string> { "Mot", "Hai", "Ba", "Bon", "Nam" };

        Console.WriteLine("Danh sach ban dau: " + string.Join(", ", words));
        words.Reverse();

        Console.WriteLine("Danh sach sau khi dao nguoc: " + string.Join(", ", words));
    }
}