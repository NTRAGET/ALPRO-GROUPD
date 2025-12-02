/*menghitung konversi suhu dari fahrenheit ke celcius*/

using System;

class Program
{
    static void Main()
    {
        double f = double.Parse(Console.ReadLine());
        double c = (f - 32) * 5.0 / 9.0;
        Console.WriteLine(c.ToString("F2"));
    }
}