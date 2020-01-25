using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userNbr1 = Console.ReadLine();
      int intuserNbr1 = Convert.ToInt32(userNbr1);
      
      Console.WriteLine("Give the second number!");
      string userNbr2 = Console.ReadLine();
      int intuserNbr2 = Convert.ToInt32(userNbr2);
      
      
      
      
      if (intuserNbr1 > intuserNbr2)  
      {
        Console.WriteLine("The larger number is " + intuserNbr1 + "!");
      }
      else if (intuserNbr2 > intuserNbr1) 
      {
        Console.WriteLine("The larger number is " + intuserNbr2 + "!");
      }
      else if (intuserNbr1 == intuserNbr2) 
      { 
        Console.WriteLine("They are equal!");
      }
      
    }
  }
}
