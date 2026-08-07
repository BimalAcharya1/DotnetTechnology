using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Method_Overriding_Using_Virtual_Method
{
    public static void Main()
    {
        Animal a = new Dog();
        a.Sound();
    }
}
