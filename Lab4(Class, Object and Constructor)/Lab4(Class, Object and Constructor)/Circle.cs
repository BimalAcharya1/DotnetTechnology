using System;

class Circle
{
    private float radius;

    public Circle(float r)
    {
        radius = r;
    }

    public float findArea()
    {
        return (float)(Math.PI * radius * radius);
    }

    public float findCircumference()
    {
        return (float)(2 * Math.PI * radius);
    }
}

class MyCircle
{
    public static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine("Area: " + c.findArea());
        Console.WriteLine("Circumference: " + c.findCircumference());
    }
}
