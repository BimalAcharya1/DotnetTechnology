using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class a_Single_Level_Inheritance
{
    public static void Main()
    {
        Dog d = new Dog();

        d.Eat();
        d.Bark();
    }
}
