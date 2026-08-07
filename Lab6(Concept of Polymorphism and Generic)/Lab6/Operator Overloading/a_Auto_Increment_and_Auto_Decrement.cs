using System;

class number
{
    int Value;

    public number(int v)
    {
        Value = v;
    }

    public static number operator ++(number n)
    {
        n.Value++;
        return n;
    }

    public static number operator --(number n)
    {
        n.Value--;
        return n;
    }

    public void Display()
    {
        Console.WriteLine("Value = " + Value);
    }
}

class a_Auto_Increment_and_Auto_Decrement
{
    public static void Main()
    {
        number n = new number(10);

        ++n;
        n.Display();

        --n;
        n.Display();
    }
}
