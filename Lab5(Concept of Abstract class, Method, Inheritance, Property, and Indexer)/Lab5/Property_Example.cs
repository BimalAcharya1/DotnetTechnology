using System;

class Student
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Property_Example
{
    public static void Main()
    {
        Student s = new Student();

        s.Name = "Bimal";

        Console.WriteLine("Student Name: " + s.Name);
    }
}
