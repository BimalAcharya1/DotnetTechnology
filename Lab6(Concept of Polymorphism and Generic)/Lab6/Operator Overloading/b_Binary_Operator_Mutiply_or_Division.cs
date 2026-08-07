using System;

class Number
{
    int value;

    public Number(int v)
    {
        value = v;
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number(a.value * b.value);
    }

    public static Number operator /(Number a, Number b)
    {
        return new Number(a.value / b.value);
    }

    public void Display()
    {
        Console.WriteLine("Value = " + value);
    }
}

class b_Binary_Operator_Mutiply_or_Division
{
    public static void Main()
    {
        Number n1 = new Number(20);
        Number n2 = new Number(10);

        Number mul = n1 * n2;
        Number div = n1 / n2;

        Console.Write("Multiplication: ");
        mul.Display();

        Console.Write("Division: ");
        div.Display();
    }
}
