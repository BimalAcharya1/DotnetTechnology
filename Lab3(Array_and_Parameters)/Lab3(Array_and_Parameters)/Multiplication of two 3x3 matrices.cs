using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Multiplication_of_two_3x3_matrices
    {
        public static void Main()
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            Console.WriteLine("Enter Matrix A:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    A[i, j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Matrix B:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    B[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        C[i, j] += A[i, k] * B[k, j];
                }
            }

            Console.WriteLine("Result Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(C[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
