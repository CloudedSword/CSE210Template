using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter Magic Number: ");
        //string userMagicNumber = Console.ReadLine();
        //int magicNumber = int.Parse(userMagicNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        int timesGuessed = 0;

        do
        {
            Console.Write("Enter your guess: ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            timesGuessed += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Too Low!");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Too High!");
            }

            else
            {
                Console.WriteLine("You Got it!");
            }


        } while (magicNumber != guess);

        Console.WriteLine($"You guessed {timesGuessed} times!");

    }
}