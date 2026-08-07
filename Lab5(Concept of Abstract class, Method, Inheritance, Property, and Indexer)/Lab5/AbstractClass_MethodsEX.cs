using System;


namespace Lab5
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class AbstractClass_MethodsEX
    {
        public static void Main()
        {
            Shape s = new Circle();
            s.Draw();
        }
    }
}
