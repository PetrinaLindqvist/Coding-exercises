using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine());

      // Implement the search functionality here
      bool found = false;

      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] == searching)
        {
          Console.WriteLine(searching + " is at index " + i + ".");
          found = true;
        }

      } 
      if (!found)
      {
          Console.WriteLine(searching + " was not found.");
      }
    }

  }
}


