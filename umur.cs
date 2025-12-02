/*program menentukan status dewasa atau anak-anak berdasarkan umur*/

using System;

class Program
{
    static void Main()
    {
        int umur = int.Parse(Console.ReadLine());   // baca umur

        if (umur >= 18)
        {
            Console.WriteLine("Dewasa");
        }
        else
        {
            Console.WriteLine("Anak-anak");
        }
    }
}