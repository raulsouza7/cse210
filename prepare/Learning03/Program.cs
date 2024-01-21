using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using different constructors
        Fraction defaultFraction = new Fraction(); // This will be 1/1
        Fraction singleParamFraction = new Fraction(5); // This will be 5/1
        Fraction thirdFraction = new Fraction(3, 4); // This will be 3/4
        Fraction fourthFraction = new Fraction(1, 3); // This will be 1/3

        // Display default fraction
        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        // Display single parameter fraction
        Console.WriteLine(singleParamFraction.GetFractionString());
        Console.WriteLine(singleParamFraction.GetDecimalValue());

        // Display third fraction
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        // Display fourth fraction
        Console.WriteLine(fourthFraction.GetFractionString());
        Console.WriteLine(fourthFraction.GetDecimalValue());
    }
}