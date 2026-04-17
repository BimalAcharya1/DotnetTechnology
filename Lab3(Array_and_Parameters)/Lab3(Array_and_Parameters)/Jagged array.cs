using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Jagged_array
    {
        public static void Main()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };
            arr[1] = new int[] { 3, 4, 5 };
            arr[2] = new int[] { 6 };

            foreach (var row in arr)
            {
                foreach (var val in row)
                    Console.Write(val + " ");
                Console.WriteLine();
            }
        }
    }
}
