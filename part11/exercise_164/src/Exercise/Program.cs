namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      StandardSensor ten = new StandardSensor(10);
      StandardSensor minusFive = new StandardSensor(-5);

      Console.WriteLine(ten.Read());
      Console.WriteLine(minusFive.Read());

      Console.WriteLine(ten.IsOn());
      ten.SetOff();
      Console.WriteLine(ten.IsOn());
    }
  }
}
