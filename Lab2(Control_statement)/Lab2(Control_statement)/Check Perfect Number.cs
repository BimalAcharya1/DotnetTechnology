using System;


namespace DotnetLabworkscollection.Lab2
{
    public class Check_Perfect_Number
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            if (sum == n)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect");
        }
    }
}
