using System;

class b_IndexOutOfRangeException
{
    public static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3 };

            Console.WriteLine(arr[5]);
        }

        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index out of range");
        }
    }
}

