using System;

class _7_Name_Length_Exception_Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            if (name.Length > 10)
            {
                throw new Exception("Name length greater than 10 characters");
            }

            Console.WriteLine("Name = " + name);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


