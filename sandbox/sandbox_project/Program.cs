using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(Sum(5));
    }

    static int Sum(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + Sum(n - 1);
    }
}
