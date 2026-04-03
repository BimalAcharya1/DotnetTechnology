using System;

class Convert
{
    static void Main()
    {
        Console.Write("Enter Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit = " + f);
    }
}
