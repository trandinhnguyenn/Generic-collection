using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tran Dinh Nguyen - MSSV: 2415053122225\n");
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango" };
        Console.WriteLine("Danh sach: " + string.Join(", ", fruits));

        Console.Write("Nhap ten trai cay can tim: ");
        string search = Console.ReadLine();

        if (fruits.Contains(search))
        {
            Console.WriteLine("Ket qua: Ton tai trong danh sach.");
        }
        else
        {
            Console.WriteLine("Ket qua: Khong ton tai.");
        }
    }
}