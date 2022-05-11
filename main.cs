// Cristiano
// ICS2O-Unit5-07-CSharp
// May 11 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int integer;
        int answer;
        string text;

        Console.WriteLine("Enter integer:");
        while (!int.TryParse(Console.ReadLine(), out integer))
        {
            Console.WriteLine("Error 2: This isn't an integer.");
            Environment.Exit(0);
        }
        if (integer < 0)
        {
            Console.WriteLine("Error 1: This integer is negative.")
            Environment.Exit(0);
        }
        else
        {
            answer = 1
            for (let count = 1; count < integer; count++) {
                counter++
                text = text + " + " + counter
                answer = answer + counter
            }
            Console.WriteLine("\n" + answer);
            Console.WriteLine("is the answer of ");
            Console.WriteLine("\nFinished.");
        }
    }
}