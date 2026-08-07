using System;
using System.Collections.Generic;

class a_List
{
    public static void Main()
    {
        List<string> list = new List<string>();

        list.Add("DotNet");
        list.Add("Computer Graphics");
        list.Add("Computer Networking");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}
