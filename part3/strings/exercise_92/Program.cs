using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 2020;
            int length = 0; 
            string longestName = "";   
            int age = 0;
            int nameLength = 0;
            
            

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] parts = input.Split(",");

                if (Convert.ToInt32(parts[1]) < oldest)
                {
                    oldest = Convert.ToInt32(parts[1]);
                }
            
                string word = parts[0];
                length = word.Length;

                if (length > nameLength)
                {
                   nameLength = length; 
                   longestName = parts[0];
                }
        
            }
        
         age = 2020 - oldest;

         Console.WriteLine("Longest name: " + longestName);
         Console.WriteLine("Highest age: " + age);


          

        }
    }
}


