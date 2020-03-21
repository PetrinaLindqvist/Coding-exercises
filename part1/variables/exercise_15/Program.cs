using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string userInput1 = Console.ReadLine();

      Console.WriteLine("Give an integer:");
      string userInput2 = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput2);

      Console.WriteLine("Give a double:");
      string userInput3 = Console.ReadLine();
      double deciMal = Convert.ToDouble(userInput3);

      Console.WriteLine("Give a boolean:");
      string userInput4 = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(userInput4);

      Console.WriteLine("Your string: " + userInput1);    
      Console.WriteLine("Your integer: " + userInput2);
      Console.WriteLine("Your double: " + userInput3);
      Console.WriteLine("Your boolean: " + userInput4);
    
    
    }
  }
}
