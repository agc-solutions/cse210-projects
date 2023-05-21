using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


        // //Another way to do this assignment
        // fraction output = new Fraction();
        // output.Top=1;
        // Console.Write(output.GetFractionString());
        // Console.Write("\n");
        // Console.Write(output.getDecimal());
        // Console.Write("\n");

        // output.Top = 5
        // Console.Write(output.GetFractionString());
        // Console.Write("\n");
        // Console.Write(output.getDecimal());
        // Console.Write("\n");

        // output.Top = 3;
        // output.Bottom = 4;
        // Console.Write(output.GetFractionString());
        // Console.Write("\n");
        // Console.Write(output.getDecimal());
        // Console.Write("\n");

        // output.Top = 1;
        // output.Bottom = 3;
        // Console.Write(output.GetFractionString());
        // Console.Write("\n");
        // Console.Write(output.getDecimal());
        // Console.Write("\n");

    }
}

