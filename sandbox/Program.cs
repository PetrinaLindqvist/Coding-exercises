using System;

namespace sandbox 
{
    class Program 
    {
        static void Main (string[] args) 
        {
           int sum = 0;
           int count = 0;
           while (true)
           {
               
               Console.WriteLine("Give a number:");
               int nbr = Convert.ToInt32(Console.ReadLine());
               
               
               if (nbr == 0)
               {
                   break;
               }
               else 
               {
                    sum =  sum + nbr;
                    count++;
               }     
               
          
           }
           
        Console.WriteLine("Total sum of numbers: " + sum);
        Console.WriteLine("Total amount of numbers: " + count);
        
        }
    }
}