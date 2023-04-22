using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int myNumber = PromptUserNumber();
        int numberSquare = SquareNumber(myNumber);

        DisplayResult(userName, numberSquare);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: "); 
        string name = Console.ReadLine();

        return name; 
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: "); 
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber; 
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}