using System;
using System.Collections.Generic;
Console.WriteLine(Factorial(5));
int Factorial(int n)
{
    if (n <= 1)
    {
        // 1! = 1 (no recursion)
        return 1;
    }
    else
    {
        // n! = n * (n - 1)!
        return (n * Factorial(n - 1));
    }
}