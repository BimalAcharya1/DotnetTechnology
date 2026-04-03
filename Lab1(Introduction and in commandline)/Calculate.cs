using System;
class Calculate
{
 public static void Main(String[] args)
{
  Console.WriteLine("Enter Length:");
  double l=Convert.ToDouble(Console.ReadLine());
  
  Console.WriteLine("Enter breadth:");
  double b=Convert.ToDouble(Console.ReadLine());
 
  double area=l*b;
  double perimeter=2*(l+b);

  Console.WriteLine("Area:"+area);
  Console.WriteLine("Perimeter:"+perimeter);

  Console.ReadKey();
}
}