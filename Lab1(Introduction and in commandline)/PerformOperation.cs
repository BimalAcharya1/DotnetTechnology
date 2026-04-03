using System;
class PerformOperation
{
 public static void Main(String[] args)
{
  int a=int.Parse(args[0]);
  int b=int.Parse(args[1]);
  int add=a+b;
  int sub=a-b;
  int mul=a*b;
  int div=a/b; 
  Console.WriteLine("Addition:"+add);
  Console.WriteLine("Substraction:"+sub);
  Console.WriteLine("Multiply:"+mul);
  Console.WriteLine("Division:"+div);
}
}