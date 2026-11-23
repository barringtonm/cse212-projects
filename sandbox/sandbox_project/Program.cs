using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(BinarySearch(new int[] { 1, 3, 6, 18, 20, 25, 34, 38, 89, 95, 99, 100 }, 89)); // true
        Console.WriteLine(BinarySearch(new int[] { 1, 3, 6, 18, 20, 25, 34, 38, 89, 95, 99, 100 }, 1));  // true
        Console.WriteLine(BinarySearch(new int[] { 1, 3, 6, 18, 20, 25, 34, 38, 89, 95, 99, 100 }, 17)); // false
    }





    static bool BinarySearch(int[] sortedArray, int target)
    {
        if (sortedArray.Length == 1)
        {
            // Base case
            return target == sortedArray[0];
        }
        else
        {
            // Find the middle and compare
            var middle = sortedArray.Length / 2;

            if (target == sortedArray[middle])
            {
                // We got lucky and the middle was the match
                return true;
            }
            else if (target < sortedArray[middle])
            {
                // Search the first half (index 0 to middle-1) and return the result
                return BinarySearch(sortedArray[..middle], target);
            }
            else
            {
                // Search the second half (index middle to end) and return the result
                return BinarySearch(sortedArray[middle..], target);
            }
        }

    }






}