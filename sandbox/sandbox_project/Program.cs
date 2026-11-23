using System;
using System.Collections.Generic;
Permutations("ABCD");
void Permutations(string letters, string word = "")
{
    // Try adding each of the available letters
    // to the 'word' and add up all the
    // resulting permutations.
    if (letters.Length == 0)
    {
        Console.WriteLine(word);
    }
    else
    {
        for (var i = 0; i < letters.Length; i++)
        {
            // Make a copy of the letters to pass to the
            // the next call to permutations.  We need
            // to remove the letter we just added before
            // we call permutations again.
            var lettersLeft = letters.Remove(i, 1);

            // Add the new letter to the word we have so far
            Permutations(lettersLeft, word + letters[i]);
        }
    }
}
