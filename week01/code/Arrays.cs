using System;
using System.Collections.Generic;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double value, int count)
    {
        //1.Create a new array of the required size
        double[] result = new double[count];

        // 2.loop through to populate the array with multiples
        for (int i = 0; i < count; i++)
        {

            //3.Calculate the multiple(index + 1 multiplied by the start value)
            //and assign it to the currentindex
            result[i] = value * (i + 1);
        }
        // 4. Return the populated array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //1.Handle edge caseswhere no rotation isneede or possible
        if (data == null || data.Count <= 1 || amount <= 0)
        {
            return;
        }

        // 2.Normalize the rotation amount using modulo to handle large numbers safely
        int k = amount % data.Count;
        if (k == 0)
        {

            return;

        }


        // 3. Determine the index where the list splits

        int splitIndex = data.Count - k;

        // 4.Extract the right most section that will shift to the front
        List<int> rightPart = data.GetRange(splitIndex, k);

        //5.Extract the left remaining left most section.
        data.RemoveRange(splitIndex, k);
        //6. Insert that section cleanly at index 0 (the very front)
        data.InsertRange(0, rightPart);
    }
}