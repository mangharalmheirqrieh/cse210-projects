// Mheirqrieh F. Mangharal
// March 4 , 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine(" ");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}