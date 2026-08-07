using System;

class c_InvalidCastException
{
    public static void Main()
    {
        try
        {
            object obj = "Hello";

            int n = (int)obj;

            Console.WriteLine(n);
        }

        catch (InvalidCastException e)
        {
            Console.WriteLine("Invalid Type Casting");
        }
    }
}

