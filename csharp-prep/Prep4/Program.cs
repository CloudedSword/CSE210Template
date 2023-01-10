using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a series of numbers, type zero to finish.");
        int inputNumber = -1;
        int sum = 0;
        int largestNumber = 0;

        do
        {
            Console.Write("Enter Number: ");
            inputNumber = int.Parse(Console.ReadLine());
            numbers.Add(inputNumber);
        } while(inputNumber != 0);
        
        numbers.Remove(0);
        int length = numbers.Count;
        //Console.WriteLine(length);

        foreach (int unit in numbers)
        {
            Console.WriteLine(unit);
            sum += unit;
            if (unit > largestNumber)
            {
                largestNumber = unit;
            }
        }
        
        float average = (float)sum / length;

        Console.WriteLine(sum);
        Console.WriteLine(largestNumber);
        Console.WriteLine(average);
    }
}