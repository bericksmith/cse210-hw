using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int newNumber = -1;
        while (newNumber != 0)
        {
            Console.Write("Enter number:");

            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }

        }

        int listTotal = 0;
        foreach (int number in numbers)
        {
            listTotal += number;
        }

        Console.WriteLine($"The sum is: {listTotal}");

        float listAverage = ((float)listTotal) / numbers.Count;

        Console.WriteLine($"The average is: {listAverage}");

        int highest = 0;

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }

        Console.WriteLine($"The largest number is: {highest}");

        int smallest = 9999;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallest > number)
                smallest = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
        Console.WriteLine($"{number}");
        }

    }
}