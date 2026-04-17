using System;


namespace DotnetLabworkscollection.Lab2
{
    public class Check_Prime_Number
    {
        
            public static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                int count = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        count++;
                }

                if (count == 2)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime");
            
        }
    }
}