using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter a number for the numerator");
        //string numerator = Console.ReadLine();

        //Console.WriteLine("Enter a number for the denominator");
        //string denominator = Console.ReadLine();

        //Fraction createFraction1 = new Fraction();
        //Fraction createFraction2 = new Fraction(numerator);
        //Fraction createFraction3 = new Fraction(numerator, denominator);

        Fraction test1 = new Fraction();
        test1.SetNumerator("1");
        test1.GetFractionString();
        test1.GetDecimalValue();

        Fraction test2 = new Fraction();
        test2.SetNumerator("5");
        test2.GetFractionString();
        test2.GetDecimalValue();

        Fraction test3 = new Fraction();
        test3.SetNumerator("3");
        test3.SetDenominator("4");
        test3.GetFractionString();
        test3.GetDecimalValue();

        Fraction test4 = new Fraction();
        test4.SetNumerator("1");
        test4.SetDenominator("3");
        test4.GetFractionString();
        test4.GetDecimalValue();

    }
}