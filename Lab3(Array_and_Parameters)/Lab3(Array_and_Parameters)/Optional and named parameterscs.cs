using System;


namespace DotnetLabworkscollection.Lab3_Array_and_Parameters_
{
    public class Optional_and_named_parameterscs
    {
        public static void Show(string name, int age = 18)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }

        public static void Main()
        {
            Show("Bimal");               // optional
            Show(age: 25, name: "Ram");  // named
        }
    }
}
