using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInput1 = Convert.ToInt32(Console.ReadLine());
      int userInput2 = Convert.ToInt32(Console.ReadLine());
     
      if (userInput1 > userInput2)    
      {
          Console.WriteLine(userInput1 + " is greater than " + userInput2 + ".");
      } 
      else if (userInput1 < userInput2)
      {
          Console.WriteLine(userInput1 + " is less than " + userInput2 + ".");
      }
      else 
      {
          Console.WriteLine(userInput1 + " is equal to " + userInput2 + ".");
      }
    }
  }
}
