/*menghitung konversi kg ke gram dan pound*/

using System;

class Program
{
    static void Main()
    {
        double kg = double.Parse(Console.ReadLine());

        int gram = (int)(kg * 1000);
        double pound = kg * 2.20462;

        Console.WriteLine(gram);
        Console.WriteLine(pound.ToString("F2"));
    }
}
