using System;

class Built_in_Generic_Delegate
{
    public static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;

        Console.WriteLine("Sum = " + add(10, 20));

        Action<string> msg = s => Console.WriteLine(s);

        msg("Hello Delegate");

        Predicate<int> check = x => x > 5;

        Console.WriteLine(check(10));
    }
}

