using System;

class Demo
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Method_Overloading
{
    public static void Main()
    {
        Demo d = new Demo();

        Console.WriteLine("Sum of 2 numbers: " + d.Add(10, 20));
        Console.WriteLine("Sum of 3 numbers: " + d.Add(10, 20, 30));
    }
}
