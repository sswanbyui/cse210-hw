using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0, guessNumber = 0, guesses = 0;
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);
        while(magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            guesses ++;
            if(guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Number of guesses: {guesses}");
                Console.Write("Would you like to play again? ");
                string playAgain = Console.ReadLine();
                if(playAgain == "yes")
                {
                    magicNumber = randomGenerator.Next(1, 101);
                    guessNumber = 0;
                }            
            }
        }
    }
}