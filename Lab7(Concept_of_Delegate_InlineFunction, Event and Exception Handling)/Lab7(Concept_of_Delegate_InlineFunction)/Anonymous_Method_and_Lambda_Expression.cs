using System;

delegate int Square(int x);

class Anonymous_Method_and_Lambda_Expression
{
    public static void Main()
    {
        // Anonymous Method
        Square s1 = delegate (int x)
        {
            return x * x;
        };

        Console.WriteLine("Anonymous Method: " + s1(5));

        // Lambda Expression
        Square s2 = x => x * x;

        Console.WriteLine("Lambda Expression: " + s2(6));
    }
}

