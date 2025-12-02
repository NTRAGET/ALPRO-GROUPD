/*menghitung konversi meter ke kilometer*/

using System;

class Program
{
    static void Main()
    {
        double meter = double.Parse(Console.ReadLine());
        double km = meter / 1000.0;
        Console.WriteLine(km.ToString("F3"));
    }
}
