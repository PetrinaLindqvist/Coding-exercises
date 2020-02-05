using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string UserInput1 = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string UserInput2 = Console.ReadLine();
      int intValue = Convert.ToInt32(UserInput2);
      Console.WriteLine("Give a double:");
      string UserInput3 = Console.ReadLine();
      double deciMal = Convert.ToDouble(UserInput3);
      Console.WriteLine("Give a boolean:");
      string UserInput4 = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(UserInput4);
      Console.WriteLine("Your string: " + UserInput1);    
      Console.WriteLine("Your integer: " + UserInput2);
      Console.WriteLine("Your double: " + UserInput3);
      Console.WriteLine("Your boolean: " + UserInput4);
    
    
    }
  }
}
