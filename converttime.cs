/*menghitung konversi detik ke jam, menit, dan detik*/

using System;

class Program
{
    static void Main()
    {
        int total = int.Parse(Console.ReadLine());   // baca total detik

        int jam = total / 3600;                      // 1 jam = 3600 detik
        int sisa = total % 3600;                     // sisa detik setelah ambil jam

        int menit = sisa / 60;                       // 1 menit = 60 detik
        int detik = sisa % 60;                       // sisa detik

        Console.WriteLine(jam + ":" + menit + ":" + detik);   // tampilkan hasil
    }
}