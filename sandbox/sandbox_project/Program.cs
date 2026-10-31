using System;
using Microsoft.VisualBasic;

public class Program
{
    static void Main()
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.


        Console.WriteLine("----Starting Array Boundaries");


        //1. Declare a fixed-size array with 3 slots
        //Indices available: 0, 1, 2
        string[] planets = new string[3] { "Mercury", "Venus", "Earth" };

        //2. Accessing a valid index (0(1) constant time)
        Console.WriteLine($"planets at index 1 is: {planets[1]}");
        //3. Intentional Error: Let's try to access index3.
        // Because arrays are  0- index, an array of size 3 does NOT have an index of 3!
        //  invalid index (3) which is out of bounds
        Console.WriteLine("Attempting to access index3....");
        string mysteryPlanets = planets[2];
        //4. This line below  will not be reached!
        Console.WriteLine($" Mystery planet: {mysteryPlanets}");
    }
}