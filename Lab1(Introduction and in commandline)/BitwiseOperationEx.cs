using System;

class BitwiseOperationEx
{
    static void Main()
    {
        int a = 5, b = 3;

        Console.WriteLine("AND: " + (a & b));
        Console.WriteLine("OR: " + (a | b));
        Console.WriteLine("XOR: " + (a ^ b));
        Console.WriteLine("Left Shift: " + (a << 1));
        Console.WriteLine("Right Shift: " + (a >> 1));
    }
}
