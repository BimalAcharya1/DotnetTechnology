using System;
using System.Collections.Generic;

class b_Stack
{
    public static void Main()
    {
        Stack<int> s = new Stack<int>();

        s.Push(10);
        s.Push(20);
        s.Push(30);

        while (s.Count > 0)
        {
            Console.WriteLine(s.Pop());
        }
    }
}
