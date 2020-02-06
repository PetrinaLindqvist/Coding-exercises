using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
     
        int oldest = 0;
        string name = "";
        while(true) {
          string asked = Console.ReadLine();
          if (asked == "") {
            break;
          }
          string[] parts = asked.Split(",");
         if (Convert.ToInt32(parts[1]) > oldest) {
           oldest = Convert.ToInt32(parts[1]);
           name = parts[0];
         }

     
    }   
    Console.WriteLine("Name of the oldest: " + name);
    }


  }
}




