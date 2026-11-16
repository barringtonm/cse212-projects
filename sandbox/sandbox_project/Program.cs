using System;
using System.Collections;
namespace ArrayListExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //code from your book
            //var result = DoSomething("Hello World");
            //Console.WriteLine(result);
            ArrayList arrayList = new ArrayList() { 5 };
            arrayList.Add(6);
            arrayList.AddRange(new int[] { -7, 8, });
            arrayList.AddRange(new object[] { "Marcin", "Kate" });
            arrayList.Insert(5, 7.8);

            //Added loop so you can see the output in the console.
            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }


        }
        //public static string DoSomething(string text)
        // {
        // var newText = "";
        //foreach (var letter in text)
        // {
        //if (letter != ' ')
        //   {
        //var newLetter = (char)(letter + 1);
        // newText += newLetter;
        //   }
        //  else
        //  {
        // newText += letter;
        //

        // 📍// PUT IT HERE (Just before returning the value)
        //  Console.WriteLine(newText);
        // return newText;
    }
}