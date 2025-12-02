/*program menampilkan nama hari berdasarkan nomor hari dalam seminggu*/

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());   // baca angka 1-7

        if (n == 1) Console.WriteLine("Senin");
        else if (n == 2) Console.WriteLine("Selasa");
        else if (n == 3) Console.WriteLine("Rabu");
        else if (n == 4) Console.WriteLine("Kamis");
        else if (n == 5) Console.WriteLine("Jumat");
        else if (n == 6) Console.WriteLine("Sabtu");
        else if (n == 7) Console.WriteLine("Minggu");
        else Console.WriteLine("Input tidak valid");   // selain 1-7
    }
}