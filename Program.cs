// See https://aka.ms/new-console-template for more information
using System;

public class Zadanie3
{
    public static void Main(string[] args)
    {
        double waga, wzrost;

        Console.WriteLine("Podaj wagę w kg");
        waga = inputValue();
        Console.WriteLine("Podaj wzrost w m");
        wzrost = inputValue();
        double bMI;

        bMI = waga / Math.Pow(wzrost, 2);
        Console.WriteLine("Twoje BMI to");
        Console.WriteLine(bMI);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

