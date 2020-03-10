using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give three numbers:");
      int userinput1 = Convert.ToInt32(Console.ReadLine());
      int userinput2 = Convert.ToInt32(Console.ReadLine());
      int userinput3 = Convert.ToInt32(Console.ReadLine());

      if (userinput1 > userinput2 && userinput1 > userinput3)
      {
        Console.WriteLine("Largest: " + userinput1);
      }
      else if (userinput2 > userinput1 && userinput2 > userinput3)
      {
        Console.WriteLine("Largest: " + userinput2);
      }
      else
      {
        Console.WriteLine("Largest: " + userinput3);
      }
    }
  }
}
