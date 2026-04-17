using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Pass_by_value___reference
    {
        public static void ByValue(int x)
        {
            x = x + 10;
        }

        public static void ByRef(ref int x)
        {
            x = x + 10;
        }

        public static void Main()
        {
            int a = 5;

            ByValue(a);
            Console.WriteLine("After ByValue: " + a);

            ByRef(ref a);
            Console.WriteLine("After ByRef: " + a);
        }
    }
}
