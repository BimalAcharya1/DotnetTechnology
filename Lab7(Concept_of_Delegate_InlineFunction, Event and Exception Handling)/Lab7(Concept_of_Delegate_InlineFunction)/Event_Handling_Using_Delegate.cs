using System;

delegate void Notify();

class EventDemo
{
    public event Notify OnProcess;

    public void StartProcess()
    {
        Console.WriteLine("Process Started");

        if (OnProcess != null)
        {
            OnProcess();
        }
    }
}

class Event_Handling_Using_Delegate
{
    static void Message()
    {
        Console.WriteLine("Event Executed");
    }

    public static void Main()
    {
        EventDemo e = new EventDemo();

        e.OnProcess += Message;

        e.StartProcess();
    }
}

