using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    
    {
      // Write your code here:
      int countNeg = 0;
      while (true)
    {
      Console.WriteLine("Give a number:"); 
      int intValue = Convert.ToInt32(Console.ReadLine());
      
      if (intValue == 0)
      {
      break;      
      }
      if (intValue < 0)
      {
        countNeg ++;
      }
    }
    Console.WriteLine("Total amount of negative numbers: " + countNeg);
  }
    
  }
}
