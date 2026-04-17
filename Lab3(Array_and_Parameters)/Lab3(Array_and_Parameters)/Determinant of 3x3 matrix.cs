using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
   public class Determinant_of_3x3_matrix
    {
        public static void Main()
        {
            int[,] a = new int[3, 3];

            Console.WriteLine("Enter 3x3 matrix:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = int.Parse(Console.ReadLine());

            int det =
                a[0, 0] * (a[1, 1] * a[2, 2] - a[1, 2] * a[2, 1]) -
                a[0, 1] * (a[1, 0] * a[2, 2] - a[1, 2] * a[2, 0]) +
                a[0, 2] * (a[1, 0] * a[2, 1] - a[1, 1] * a[2, 0]);

            Console.WriteLine("Determinant = " + det);
        }
    }
}
