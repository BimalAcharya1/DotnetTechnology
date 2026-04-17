using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Sum_of_diagonal_elements__3x3_matrix_
    {
        public static void Main()
        {
            int[,] mat = new int[3, 3];
            Console.WriteLine("Enter 3x3 matrix:");

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mat[i, j] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < 3; i++)
                sum += mat[i, i];   // main diagonal

            Console.WriteLine("Diagonal sum = " + sum);
        }
    }
}
