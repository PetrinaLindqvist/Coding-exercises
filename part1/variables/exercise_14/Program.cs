﻿
using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:
      string userInput = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(userInput);
      Console.WriteLine(booleanValue);
    }
  }
}
