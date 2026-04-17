using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class params_keyword
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
                sum += x;
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("Sum = " + Sum(1, 2, 3, 4));
        }
    }
}
