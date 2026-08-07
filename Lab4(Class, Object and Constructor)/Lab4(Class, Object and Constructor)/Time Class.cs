using System;

class Time
{
    int hours, minutes, seconds;

    public Time(int h, int m, int s)
    {
        hours = h;
        minutes = m;
        seconds = s;
    }

    public void Display()
    {
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
    }

    public Time Add(Time t)
    {
        int h = hours + t.hours;
        int m = minutes + t.minutes;
        int s = seconds + t.seconds;

        if (s >= 60)
        {
            m += s / 60;
            s = s % 60;
        }

        if (m >= 60)
        {
            h += m / 60;
            m = m % 60;
        }

        return new Time(h, m, s);
    }

    public Time Subtract(Time t)
    {
        int total1 = hours * 3600 + minutes * 60 + seconds;
        int total2 = t.hours * 3600 + t.minutes * 60 + t.seconds;

        int diff = total1 - total2;

        int h = diff / 3600;
        diff %= 3600;
        int m = diff / 60;
        int s = diff % 60;

        return new Time(h, m, s);
    }
}

class Testtime
{
    public static void Main()
    {
        Time t1 = new Time(2, 45, 50);
        Time t2 = new Time(1, 20, 30);

        Time add = t1.Add(t2);
        Time sub = t1.Subtract(t2);

        Console.Write("Addition: ");
        add.Display();

        Console.Write("Subtraction: ");
        sub.Display();
    }
}
