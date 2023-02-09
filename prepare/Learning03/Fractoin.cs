using System;
using System.Collections.Generic;

public class Fraction
{
    private string _numerator = "1";
    private string _denominator = "1";

    private void CreateFraction(string _numerator, string _denominator)
    {
        Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public Fraction()
    {
        _numerator = "1";
        _denominator = "1";
        //CreateFraction(_numerator, _denominator);
    }

    public Fraction(string numerator)
    {
        _numerator = numerator;
        _denominator = "1";  
        //CreateFraction(_numerator, _denominator);      
    }

    public Fraction(string numerator, string denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        //CreateFraction(_numerator, _denominator);
    }

    public string GetNumerator()
    {
        return _numerator;
    }

    public string GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(string numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(string denominator)
    {
        _denominator = denominator;
    }

    public void GetFractionString()
    {
        if (_denominator == "1")
        {
            Console.WriteLine(_numerator);
        }
        else
        {
            Console.WriteLine($"{_numerator}/{_denominator}");
        }
    }

    public void GetDecimalValue()
    {
        int numnumerator = int.Parse(_numerator);
        int numdenominator = int.Parse(_denominator);
        double decimalValue = numdenominator / numdenominator;
        Console.WriteLine(decimalValue);
    }


}