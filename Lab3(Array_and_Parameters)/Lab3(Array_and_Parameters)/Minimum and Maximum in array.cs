using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Minimum_and_Maximum_in_array
    {
        public static void Main()
        {
            Console.WriteLine("Enter size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int min = arr[0], max = arr[0];

            foreach (int x in arr)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
        }
    }
}
