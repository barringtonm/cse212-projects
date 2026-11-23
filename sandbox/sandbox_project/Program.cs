using System;
using System.Collections.Generic;

int Fib(int n)
{
    if (n <= 2)
    {
        // Fib(2) = 1 and Fib(1) = 1
        return 1;
    }
    else
    {
        // Fib(n) = Fib(n - 1) + Fib(n - 2)
        return Fib(n - 1) + Fib(n - 2);
    }
}
Console.WriteLine("Enter a number to calculate its Fibonacci value:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The Fibonacci value of {number} is {Fib(number)}");
