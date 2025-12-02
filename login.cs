/*program login sederhana dengan nested if*/

using System;

class Program
{
    static void Main()
    {
        string username = Console.ReadLine();   // read username
        string password = Console.ReadLine();   // read password

        if (username == "admin")                // check username first
        {
            if (password == "12345")            // nested if: check password
            {
                Console.WriteLine("Login Berhasil");
            }
            else
            {
                Console.WriteLine("Password Salah");
            }
        }
        else
        {
            Console.WriteLine("Username Tidak Ditemukan");
        }
    }
}