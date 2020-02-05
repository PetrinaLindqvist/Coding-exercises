using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userNbr1 = Console.ReadLine();
      int intuserNbr1 = Convert.ToInt32(userNbr1);
        
      if (intuserNbr1 < 0)  
      {
        Console.WriteLine("Impossible");
      }
      else if (intuserNbr1 >0 && intuserNbr1 <50) 
      {
        Console.WriteLine("Fail");
      }
      else if (intuserNbr1 >49 && intuserNbr1 <60) 
      { 
        Console.WriteLine("Grade: 1");
      }
      else if (intuserNbr1 >59 && intuserNbr1 <70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (intuserNbr1 >69 && intuserNbr1 <80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (intuserNbr1 >79 && intuserNbr1 <90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (intuserNbr1 >89 && intuserNbr1 <101)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (intuserNbr1 >100)
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}
