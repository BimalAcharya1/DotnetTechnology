using System;


namespace DotnetLabworkscollection.Lab2
{
    public class Sum_Until_Negative_Number
    {
        public static void Main()
        {
            int sum = 0;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                    break;

                sum += n;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
