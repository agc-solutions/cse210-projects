using System;
// 1. Create a class to hold fraction
// 2. The class should be in its own file.
public class Fraction
{
    // 3. The class should have two attributes for the top and bottom numbers.
    // 4. Make sure the attributes are private.
    private int _top;
    private int _botton;

    // step 4: Create the constructors

    // A. Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }

    // B. Constructor that has one parameter for the top and that initializes the 
    //    denominator to 1. So that if you pass in the number 5, the fraction would 
    //    be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }

    // C. Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    // step 5: Create the Getters and Setters
    // Create getters and setters for both the top and the bottom values.
    // Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string text = $"{_top}/{_botton}";
        return text;
    }
    // Create a method called GetDecimalValue that returns a double that is the result of dividing
    // the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
    }
}
    