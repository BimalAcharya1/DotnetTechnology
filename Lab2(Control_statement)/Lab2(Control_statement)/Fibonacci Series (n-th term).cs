using System;


namespace DotnetLabworkscollection.Lab2
{
    public class Fibonacci_Series_n_th_term_
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("Nth term: " + b);
        }
        }
    }

