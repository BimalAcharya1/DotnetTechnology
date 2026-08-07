using System;

class Contact
{
    private string[] name = new string[5];
    private string[] phone = new string[5];

    public string this[int index, int type]
    {
        get
        {
            if (type == 0)
                return name[index];
            else
                return phone[index];
        }

        set
        {
            if (type == 0)
                name[index] = value;
            else
                phone[index] = value;
        }
    }
}

class Contact_Management_System_Using_Indexer
{
    public static void Main()
    {
        Contact c = new Contact();

        for (int i = 0; i < 2; i++)
        {
            Console.Write("Enter Name: ");
            c[i, 0] = Console.ReadLine();

            Console.Write("Enter Phone: ");
            c[i, 1] = Console.ReadLine();
        }

        Console.WriteLine("\nContact Details");

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Name: " + c[i, 0]);
            Console.WriteLine("Phone: " + c[i, 1]);
        }
    }
}
