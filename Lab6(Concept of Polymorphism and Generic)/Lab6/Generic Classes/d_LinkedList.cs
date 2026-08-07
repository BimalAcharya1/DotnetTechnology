using System;
using System.Collections.Generic;

class d_LinkedList
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(100);
        list.AddLast(200);
        list.AddLast(300);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}
