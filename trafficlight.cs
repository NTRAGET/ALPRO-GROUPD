/*program lampu lalu lintas*/

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();   // input: M / K / H

        if (s == "M")
            Console.WriteLine("Berhenti");
        else if (s == "K")
            Console.WriteLine("Hati hati");
        else if (s == "H")
            Console.WriteLine("Jalan");
        else
            Console.WriteLine("Warna salah");
    }
}