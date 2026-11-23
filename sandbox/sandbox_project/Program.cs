using System;
using System.Collections.Generic;

long Fibonacci(int n, Dictionary<int, long> remember = null)
{

    // If this is the first time calling the function, then
    // we need to create the dictionary.
    if (remember == null)
        remember = new Dictionary<int, long>();

    // Base Case
    if (n <= 2)
        return 1;

    // Check if we have solved this one before
    if (remember.ContainsKey(n))
        return remember[n];

    // Otherwise solve with recursion
    var result = Fibonacci(n - 1, remember) + Fibonacci(n - 2, remember);

    // Remember result for potential later use
    remember[n] = result;
    return result;
}



Console.WriteLine(Fibonacci(1));   // 1
Console.WriteLine(Fibonacci(2));   // 1
Console.WriteLine(Fibonacci(3));   // 2
Console.WriteLine(Fibonacci(4));   // 3
Console.WriteLine(Fibonacci(10));  // 55
Console.WriteLine(Fibonacci(90));  // 2880067194370816120 (This one will
                                   // not work if you do not have the
                                   // `remember` dictionary implemented).