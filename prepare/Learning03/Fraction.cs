using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // No-argument constructor
    public Fraction() : this(1, 1) {}

    // Constructor with numerator only
    public Fraction(int numerator) : this(numerator, 1) {}

    // Constructor with both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value != 0 ? value : 1; } // Prevent division by zero
    }

    // Method to return fraction as string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
