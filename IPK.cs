using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SIMULASI PERHITUNGAN IPK ===\n");

        // Daftar mata kuliah contoh
        string[] daftarMK = {
            "Pemrograman Dasar", "Matematika I", "Basis Data",
            "Sistem Operasi", "Bahasa Inggris", "Jaringan Komputer",
            "Algoritma", "Pancasila", "Statistika", "Sistem Digital"
        };

        // Nilai huruf yang mungkin
        string[] nilaiHuruf = { "A", "B", "C", "D", "E" };

        Random rand = new Random();

        int jumlahMK = rand.Next(5, 10); // Random 5–9 mata kuliah

        double totalBobot = 0;
        int totalSKS = 0;

        Console.WriteLine("Mata Kuliah\t\tSKS\tNilai\tBobot");

        for (int i = 0; i < jumlahMK; i++)
        {
            string mk = daftarMK[rand.Next(daftarMK.Length)];
            int sks = rand.Next(2, 4); // SKS 2–3
            string huruf = nilaiHuruf[rand.Next(nilaiHuruf.Length)];
            double angka = KonversiNilai(huruf);

            double bobot = angka * sks;

            Console.WriteLine($"{mk,-20} {sks}\t {huruf}\t {bobot}");

            totalBobot += bobot;
            totalSKS += sks;
        }

        double ipk = totalBobot / totalSKS;

        Console.WriteLine("\n============================");
        Console.WriteLine($"Total SKS : {totalSKS}");
        Console.WriteLine($"IPK Simulasi : {ipk:F2}");
        Console.WriteLine("============================");
    }

    static double KonversiNilai(string huruf)
    {
        switch (huruf)
        {
            case "A": return 4.0;
            case "B": return 3.0;
            case "C": return 2.0;
            case "D": return 1.0;
            case "E": return 0.0;
            default: return 0.0;
        }
    }
}
