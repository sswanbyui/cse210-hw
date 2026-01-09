using System;

class Program
{
    static void Main(string[] args)
    {
        int gradePCT, remainder;
        string letter = "", plusMinus = "";
        Console.Write("What is your grade percentage? ");
        gradePCT = int.Parse(Console.ReadLine());
        remainder = gradePCT % 10;

        if(gradePCT >= 90)
        {
            letter = "an A";
        }
        if(gradePCT >= 80 && gradePCT < 90)
        {
            letter = "a B";
        }
        if(gradePCT >= 70 && gradePCT < 80)
        {
            letter = "a C";
        }
        if(gradePCT >= 60 && gradePCT < 70)
        {
            letter = "a D";
        }
        if(gradePCT < 60)
        {
            letter = "an F";
        }
        if(remainder >= 7)
        {
            if(gradePCT < 90 && gradePCT >= 60)
            {
                plusMinus = "+";
            }
            else
            {
                plusMinus = "";
            }
        }
        if(remainder <=3)
        {
            plusMinus = "-";
        }
        Console.WriteLine($"Your grade is {letter}{plusMinus}.");
        if(gradePCT >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time.");
        }
    }
}