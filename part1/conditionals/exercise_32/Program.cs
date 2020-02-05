using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Speak, friend, and enter!");
      string userInput = Console.ReadLine();
      
      if (userInput == "Mellon")  
      {
        Console.WriteLine("Welcome, friend!");
      }
      else
      {
        Console.WriteLine("They've got a cave troll!");
      }
    }
  }
}
