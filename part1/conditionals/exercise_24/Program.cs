using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed:");
      string userSpeed = Console.ReadLine();
      int speed = Convert.ToInt32(userSpeed);
      if (speed > 120)
      {
        Console.WriteLine("Speeding!");
      }
   
   
   
    }
  }
}
