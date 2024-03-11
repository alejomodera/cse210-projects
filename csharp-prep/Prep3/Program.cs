using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess; 

        do{
            Console.Write("what is your guess?: ");
            string guessinput = Console.ReadLine();
            int guessnumber = int.Parse(guessinput);
            
            guess = guessnumber;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You have guessed!");
            }

        } while (guess != magicNumber);
    }
}