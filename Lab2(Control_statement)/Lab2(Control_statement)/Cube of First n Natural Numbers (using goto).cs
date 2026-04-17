using System;

namespace DotnetLabworkscollection.Lab2
{
    public class Cube_of_First_n_Natural_Numbers__using_goto_
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;

        start:
            if (i <= n)
            {
                Console.WriteLine("Cube of " + i + " = " + (i * i * i));
                i++;
                goto start;
            }
        }
    }
}
