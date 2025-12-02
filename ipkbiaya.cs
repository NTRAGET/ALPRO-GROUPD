/* Program untuk menentukan kelulusan berdasarkan IPK dan pendapatan orang tua */

using System;

class Program
{
    static void Main()
    {
        double ipk = double.Parse(Console.ReadLine());
        int income = int.Parse(Console.ReadLine());

        if (ipk >= 3.5)                          // Cek IPK dulu
        {
            if (income < 5000000)               // Nested: cek pendapatan
            {
                Console.WriteLine("Diterima");
            }
            else
            {
                Console.WriteLine("Ditolak (Pendapatan)");
            }
        }
        else
        {
            Console.WriteLine("Ditolak (IPK)");
        }
    }
}
