using System;

struct company
{
    public string name;
    public string address;
    public string phone;
    public float salary;
}

class structtest
{
    public static void Main()
    {
        company c;

        Console.Write("Enter Name: ");
        c.name = Console.ReadLine();

        Console.Write("Enter Address: ");
        c.address = Console.ReadLine();

        Console.Write("Enter Phone: ");
        c.phone = Console.ReadLine();

        Console.Write("Enter Salary: ");
        c.salary = float.Parse(Console.ReadLine());

        Console.WriteLine("\nCompany Details:");
        Console.WriteLine("Name: " + c.name);
        Console.WriteLine("Address: " + c.address);
        Console.WriteLine("Phone: " + c.phone);
        Console.WriteLine("Salary: " + c.salary);
    }
}
