using System;


namespace DotnetLabworkscollection.Lab2
{
    public class FindLargestat3num
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("Largest: " + a);
                else
                    Console.WriteLine("Largest: " + c);
            }
            else
            {
                if (b > c)
                    Console.WriteLine("Largest: " + b);
                else
                    Console.WriteLine("Largest: " + c);
            }
        }
    }
}
