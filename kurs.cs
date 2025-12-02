/*menghitung konversi rupiah ke dollar*/

using System;

class Program
{
    static void Main()
    {
        double rupiah = double.Parse(Console.ReadLine());
        double kurs = double.Parse(Console.ReadLine());

        double dollar = rupiah / kurs;

        Console.WriteLine(dollar.ToString("F2"));
    }
}