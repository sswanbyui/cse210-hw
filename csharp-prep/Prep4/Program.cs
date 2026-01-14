using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = -1, sum = 0, largest = 0, smallestPositive = 0;
        double average = 0.0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if(number !=0)
            {
                numbers.Add(number);
                sum += number;
                if((number < smallestPositive && number > 0) || smallestPositive == 0)
                {
                    smallestPositive = number;
                }
            }
        }
        if(numbers.Count > 0)
        {
            average = (double)sum/(double)numbers.Count;
        }
        largest = numbers.Max();
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        foreach(int i in numbers)
        {
            Console.WriteLine($"{i}");
        }

    }
}