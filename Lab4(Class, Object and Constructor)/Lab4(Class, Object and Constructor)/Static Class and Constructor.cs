
using System;


static class Demo
{
    static int x;

    static Demo()
    {
        x = 100;
        Console.WriteLine("Static Constructor Called");
    }

    public static void Show()
    {
        Console.WriteLine("Value of x: " + x);
    }
}

class Satic_Class_and_Constructors
{
    public static void Main()
    {
        Demo.Show();
    }
}
