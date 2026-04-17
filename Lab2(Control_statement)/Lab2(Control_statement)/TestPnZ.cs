using System;


namespace DotnetLabworkscollection.Lab2
{
    public class TestPnZ
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("Positive");
            else if (n < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
    }
}
