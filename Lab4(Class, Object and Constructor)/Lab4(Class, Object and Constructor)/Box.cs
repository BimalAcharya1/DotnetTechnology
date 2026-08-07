using System;

class Box
{
    private float width, height, depth;

    public Box(float w, float h, float d)
    {
        width = w;
        height = h;
        depth = d;
    }

    public float Volume()
    {
        return width * height * depth;
    }

    public float SurfaceArea()
    {
        return 2 * (width * height + height * depth + width * depth);
    }
}

class BoxEx
{
    public static void Main()
    {
        Box b1 = new Box(2, 3, 4);
        Box b2 = new Box(5, 6, 7);

        Console.WriteLine("Box1 Volume: " + b1.Volume());
        Console.WriteLine("Box1 Surface Area: " + b1.SurfaceArea());

        Console.WriteLine("Box2 Volume: " + b2.Volume());
        Console.WriteLine("Box2 Surface Area: " + b2.SurfaceArea());
    }
}
