using System;

class Parent
{
    public void Display()
    {
        Console.WriteLine("Parent Class");
    }
}

class Child1 : Parent
{
    public void Show1()
    {
        Console.WriteLine("Child1 Class");
    }
}

class Child2 : Parent
{
    public void Show2()
    {
        Console.WriteLine("Child2 Class");
    }
}

class c_Hierarchical_Inheritance
{
    public static void Main()
    {
        Child1 c1 = new Child1();
        c1.Display();
        c1.Show1();

        Child2 c2 = new Child2();
        c2.Display();
        c2.Show2();
    }
}
