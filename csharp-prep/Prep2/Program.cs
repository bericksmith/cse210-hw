using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int score = int.Parse(percent);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int[] digits = percent.ToString().Select(o => int.Parse(o.ToString())).ToArray();

        string finalSymbol = "";

        if (digits[1] >= 7)
        {
            finalSymbol = "+";

            if (letter == "A")
            {
                finalSymbol = "";
            }
            else if (letter == "F")
            {
                finalSymbol = "";
            }

        }
        else if (digits[1] < 3)
        {
            finalSymbol = "-";

            if (letter == "A")
            {
                finalSymbol = "";
            }
            else if (letter == "F")
            {
                finalSymbol = "";
            }
        }

        Console.WriteLine($"The grade is: {letter}{finalSymbol}");

        if (score >= 70)
        {
            Console.WriteLine("Great work! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry didn't quite make it!  Please try taking the class again.");
        }
    }
}