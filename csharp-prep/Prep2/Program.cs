using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent grade? (Enter a number) ");
        string stringPercentGrade = Console.ReadLine();
        int percentGrade = int.Parse(stringPercentGrade);
        string letter = "F";
        if (percentGrade >= 90)
        {
            letter = "A";
        }
        else if (percentGrade >= 80 && percentGrade < 90)
        {
            letter = "B";
        }
        else if (percentGrade >= 70 && percentGrade < 80)
        {
            letter = "C";
        }
        else if (percentGrade >= 60 && percentGrade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (percentGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have not passed... yet! Give it another shot, you got this!");
        }
    }
}