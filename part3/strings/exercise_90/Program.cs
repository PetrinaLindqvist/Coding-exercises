using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<string> persons = new List<string>();
        int oldest = 0;
        while(true) {
          string asked = Console.ReadLine();
          if (asked == "") {
            break;
          }
          string[] parts = asked.Split(",");
         if (Convert.ToInt32(parts[1]) > oldest) {
           oldest = Convert.ToInt32(parts[1]);
        }
      }

     Console.WriteLine("Age of the oldest: " + oldest);
    }
  }
}



