using System;
using System.Collections.Generic;

namespace exercise_135 
{
  class Program 
  {
    public static void Main (string[] args) 
    {
      JokeManager manager = new JokeManager();
      manager.AddJoke("What is red and smells of blue paint? - Red paint.");
      manager.AddJoke("What is blue and smells of red paint? - Blue paint.");

      Console.WriteLine("Drawing jokes:");
      for (int i = 0; i < 5; i++) 
      {
        Console.WriteLine(manager.DrawJoke());
      }

      Console.WriteLine("");
      Console.WriteLine("Printing jokes:");
      manager.PrintJokes();
    }
  }
}