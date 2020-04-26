namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      //StandardSensor ten = new StandardSensor(10);
      //StandardSensor minusFive = new StandardSensor(-5);
      //StandardSensor minusthirtytwo = new StandardSensor(-32);

      //Console.WriteLine(ten.Read());
      //Console.WriteLine(minusFive.Read());
      //Console.WriteLine(minusthirtytwo.Read());

      //Console.WriteLine(ten.IsOn());
      //ten.SetOff();
      //Console.WriteLine(ten.IsOn());
      TemperatureSensor temperatureSensor = new TemperatureSensor();
      temperatureSensor.SetOff();
      Console.WriteLine(temperatureSensor.Read());
    
    }
  }
}
