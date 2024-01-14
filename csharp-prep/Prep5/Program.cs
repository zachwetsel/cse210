using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}. ");
    }
}