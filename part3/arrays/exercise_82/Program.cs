using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array)
    
    {
       for (int i = 0; i < array.Length; i++)
       {

                if (i < array.Length - 1)
                {

                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
                
            }
          Console.WriteLine();
    }
  }
}

