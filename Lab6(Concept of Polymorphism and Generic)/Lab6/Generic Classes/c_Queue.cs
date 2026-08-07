using System;
using System.Collections.Generic;

class c_Queue
{
    public static void Main()
    {
        Queue<string> q = new Queue<string>();

        q.Enqueue("Nimesh Pokhrel");
        q.Enqueue("Albert Rai");
        q.Enqueue("Gaurav Magar");

        while (q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}
