using System;

class a_DivideByZeroException
{
    public static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;

            int c = a / b;

            Console.WriteLine(c);
        }

        catch (DivideByZeroException e)
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
}

