using System;

class LargestandSmallest
{
    static void Main()
    {
        int a = 10, b = 20, c = 5;

        int largest = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
        int smallest = (a < b) ? (a < c ? a : c) : (b < c ? b : c);

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Smallest: " + smallest);
    }
}
