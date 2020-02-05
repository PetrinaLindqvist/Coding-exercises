using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInput = Convert.ToInt32(Console.ReadLine());
      
     while (userInput <= 100)
     {
        Console.WriteLine(userInput);
        userInput++;
     }
    }
  }
}
