using System;

class Program
{
    static void Main(string[] args)
    {
     DisplayWelcomeMessage();
     string name = PromptUserName();
     int favNumber = PromptUserNumber();
     int squaredNumber = SquareNumber(favNumber);
     int birthYear;
     PromptUserBirthYear(out birthYear);
     DisplayResult(name, squaredNumber, birthYear);
    }
static void DisplayWelcomeMessage()
{
 Console.WriteLine("Welcome to the program!");
}

static string PromptUserName()
{
 Console.Write("What is your name? ");
 string name = Console.ReadLine();
 return name;
}

static int PromptUserNumber()
{
 Console.Write("What is your favorite number? ");
 int favNumber = int.Parse(Console.ReadLine());
 return favNumber;
}

static void PromptUserBirthYear(out int birthYear)
{
 Console.Write("Please enter your birth year: ");
 birthYear = int.Parse(Console.ReadLine());
}

static int SquareNumber(int number)
{
 int squaredNumber = number * number;
 return squaredNumber;
}

static void DisplayResult(string name, int squaredNumber, int birthYear)
{
 Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
 int ageThisYear = 2026-birthYear;
 Console.WriteLine($"{name}, you will turn {ageThisYear} years old this year.");
}
}