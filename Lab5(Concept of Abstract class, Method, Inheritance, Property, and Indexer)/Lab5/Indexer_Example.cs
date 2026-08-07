using System;

class Subject
{
    private string[] sub = new string[5];

    public string this[int index]
    {
        get { return sub[index]; }
        set { sub[index] = value; }
    }
}

class Indexer_Example
{
    public static void Main()
    {
        Subject s = new Subject();

        s[0] = "DotNet";
        s[1] = "Computer Graphics";
        s[2] = "Computer Networking";
        s[3] = "MIS and EBusiness";
        s[4] = "Introduction To Management";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(s[i]);
        }
    }
}
