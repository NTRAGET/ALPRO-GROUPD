/*menghitung luas dan keliling persegi panjang*/

using System;

class Program
{
    static void Main()
    {
        int panjang = int.Parse(Console.ReadLine());
        int lebar = int.Parse(Console.ReadLine());

        int luas = panjang * lebar;
        int keliling = 2 * (panjang + lebar);

        Console.WriteLine(luas);
        Console.WriteLine(keliling);
    }
}