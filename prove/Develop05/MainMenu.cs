using System;

public class MainMenu
{
    // Attributes 
    private string _menu = $@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ";

    public string _userInput;
    private int _userChoice = 0;

    // Methods
    public int UserChoice()
    // Method to display choices to user
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;

        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }



}