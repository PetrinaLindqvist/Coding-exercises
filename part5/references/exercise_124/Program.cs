using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      ProgramTests testprogram = new Testprogram();
      
      testprogram = null;
      Console.WriteLine(testprogram);
      testprogram.GrowOlder();
    }
  }
}
