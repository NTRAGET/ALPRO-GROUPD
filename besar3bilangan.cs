
/*menentukan nilai terbesar dari tiga bilangan*/

using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int terbesar;

        if (a > b)              // bandingkan a dengan b
        {
            if (a > c)          // nested: bandingkan a dengan c
            {
                terbesar = a;
            }
            else
            {
                terbesar = c;
            }
        }
        else                    // b >= a
        {
            if (b > c)          // nested: bandingkan b dengan c
            {
                terbesar = b;
            }
            else
            {
                terbesar = c;
            }
        }

        Console.WriteLine(terbesar);
    }
}
