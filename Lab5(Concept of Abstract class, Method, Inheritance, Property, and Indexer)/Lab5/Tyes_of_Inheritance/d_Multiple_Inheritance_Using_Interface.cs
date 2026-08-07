using System;

interface E
{
    void ShowE();
}

interface F
{
    void ShowF();
}

class Demo : E, F
{
    public void ShowE()
    {
        Console.WriteLine("Interface E");
    }

    public void ShowF()
    {
        Console.WriteLine("Interface F");
    }
}

class d_Multiple_Inheritance_Using_Interface
{
    public static void Main()
    {
        Demo d = new Demo();

        d.ShowE();
        d.ShowF();
    }
}
