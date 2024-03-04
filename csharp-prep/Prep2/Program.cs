// Mheirqrieh F. Mangharal
// March 4 , 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.Write("What is your Grade Percentage? ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);

        string letter = ""; //initializes the variable letter to an empty string

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        string sign = "";
        int lastDigit = x % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (x >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"You Grade is: {letter}{sign}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations you Passed");
        }
        else 
        {
            Console.WriteLine("Don't Give up");
        }
    }
}