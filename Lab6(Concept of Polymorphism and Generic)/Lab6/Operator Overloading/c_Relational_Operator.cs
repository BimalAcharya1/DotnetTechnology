using System;

class number1
{
    int Value;

    public number1(int v)
    {
        Value = v;
    }

    public static bool operator ==(number1 a, number1 b)
    {
        return a.Value == b.Value;
    }

    public static bool operator !=(number1 a, number1 b)
    {
        return a.Value != b.Value;
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}

class c_Relational_Operator
{
    public static void Main()
    {
        number1 n1 = new number1(10);
        number1 n2 = new number1(10);

        Console.WriteLine(n1 == n2);
        Console.WriteLine(n1 != n2);
    }
}
