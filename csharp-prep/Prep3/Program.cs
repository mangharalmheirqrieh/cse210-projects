// Mheirqrieh F. Mangharal
// March 4 , 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        int attemptCount;

        string response;
        
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,11);
            int guess = -1;
            attemptCount = 0;

            while (guess != magicNumber)
            {
                Console.Write(" What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attemptCount++;
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }  
            Console.WriteLine($"It took you {attemptCount} attemps");
            
            Console.Write("Do you want to continue? yes/no ");
            response = Console.ReadLine();
        }while (response == "yes");
    }
}