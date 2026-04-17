using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Print_prime_elements_from_array
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static void Main()
        {
            int[] arr = { 2, 4, 5, 7, 9, 11 };

            Console.WriteLine("Prime elements:");
            foreach (int x in arr)
                if (IsPrime(x))
                    Console.Write(x + " ");
        }
    }
}
