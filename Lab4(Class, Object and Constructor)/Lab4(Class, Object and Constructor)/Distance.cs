using System;

class Distance
{
    private int feet, inches;

    public Distance(int f, int i)
    {
        feet = f;
        inches = i;
    }

    public Distance addDistance(Distance d)
    {
        int f = feet + d.feet;
        int i = inches + d.inches;

        if (i >= 12)
        {
            f += i / 12;
            i = i % 12;
        }

        return new Distance(f, i);
    }

    public void displayDistance()
    {
        Console.WriteLine(feet + " feet " + inches + " inches");
    }
}

class MyDistance
{
    public static void Main()
    {
        Distance d1 = new Distance(5, 8);
        Distance d2 = new Distance(3, 10);

        Distance result = d1.addDistance(d2);

        Console.Write("Total Distance: ");
        result.displayDistance();
    }
}
