using System;
public class Program
{
    static void Main(string[] args)
    {
        var result = DoSomething("Hello World");
        Console.WriteLine(result);
    }
    public static string DoSomething(string text)
    {
        var newText = "";
        foreach (var letter in text)
        {
            if (letter != ' ')
            {
                var newLetter = (char)(letter + 1);
                newText += newLetter;
            }
            else
            {
                newText += letter;
            }
        }

        // 📍 PUT IT HERE (Just before returning the value)
        Console.WriteLine(newText);
        return newText;
    }
}