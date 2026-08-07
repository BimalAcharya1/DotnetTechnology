using System;
using System.Collections.Generic;

class e_Dictionary
{
    public static void Main()
    {
        Dictionary<int, string> d = new Dictionary<int, string>();

        d.Add(1, "Ram");
        d.Add(2, "Hari");
        d.Add(3, "Sita");

        foreach (KeyValuePair<int, string> item in d)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
