/*menghitung harga setelah diskon dan jumlah diskon*/

using System;

class Program
{
    static void Main()
    {
        double harga = double.Parse(Console.ReadLine());
        double diskon = double.Parse(Console.ReadLine());

        double jumlahDiskon = harga * (diskon / 100);
        double hargaSetelah = harga - jumlahDiskon;

        Console.WriteLine(hargaSetelah.ToString("F2"));
        Console.WriteLine(jumlahDiskon.ToString("F2"));
    }
}
