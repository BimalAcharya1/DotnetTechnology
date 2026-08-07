using System;

class A
{
    public void ShowA()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public void ShowB()
    {
        Console.WriteLine("Class B");
    }
}

class C : B
{
    public void ShowC()
    {
        Console.WriteLine("Class C");
    }
}

class b_Multi_Level_Inheritance
{
    public static void Main()
    {
        C obj = new C();

        obj.ShowA();
        obj.ShowB();
        obj.ShowC();
    }
}
