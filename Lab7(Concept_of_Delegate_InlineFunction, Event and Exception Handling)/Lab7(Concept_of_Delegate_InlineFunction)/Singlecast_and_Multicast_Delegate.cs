using System;

delegate void DemoDelegate();

class Test
{
    public void Show1()
    {
        Console.WriteLine("Show1 Method");
    }

    public void Show2()
    {
        Console.WriteLine("Show2 Method");
    }
}

class Singlecast_and_Multicast_Delegate
{
    public static void Main()
    {
        Test t = new Test();

        // Singlecast Delegate
        DemoDelegate d1 = t.Show1;
        d1();

        // Multicast Delegate
        DemoDelegate d2 = t.Show1;
        d2 += t.Show2;

        d2();
    }
}
