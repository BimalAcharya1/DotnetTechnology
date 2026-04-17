using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Sum_of_odd_array_elements
    {
        public static void Main()
        {
            Console.WriteLine("Enter size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int sum = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0)
                    sum += x;
            }

            Console.WriteLine("Sum of odd elements = " + sum);
        }
    }
}
