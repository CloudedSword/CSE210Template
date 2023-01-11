using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string userName = promptUserName();
        int number = favoriteNumber();
        int numberSquared = squareNumber(number);
        displayResults(userName, numberSquared);
    }

    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int favoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void displayResults(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
    }
}