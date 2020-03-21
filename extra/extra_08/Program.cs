using System;

namespace extra_08
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      ChristmasTree(4);

    }
      public static void PrintStars(int number)
      {
        for (int i = 0; i < number; i++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      
      }
      
      public static void PrintSpaces(int size)
      {
        for (int i = 1; i <= size; i++)
        {
          PrintSpaces(size-i);
          PrintStars(i);
        }
      
      
      }
      
      public static void PrintRightTriangle(int size)
    {
      int left = size -1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(left);
        PrintStars(i);
        left--;
      }
      
    } 
      public static void ChristmasTree(int height)
      {
        for (int i= 1; i<= height; i++)
        {
          PrintSpaces(height-i);
          PrintStars ((2*i)-1);
        }
        PrintSpaces(height-2);
        PrintStars(3);
        PrintSpaces(height -2);
        PrintStars(3);
      
      }
    
  }
}
