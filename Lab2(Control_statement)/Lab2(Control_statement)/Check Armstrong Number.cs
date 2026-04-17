using System;

namespace DotnetLabworkscollection.Lab2
{
    public class Check_Armstrong_Number
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum += r * r * r;
                n /= 10;
            }

            if (sum == temp)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");
        }
    }
}
