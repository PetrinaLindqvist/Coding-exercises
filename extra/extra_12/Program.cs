using System;

namespace extra_12 
{
  class Program 
  {
  
    public static void Main (string[] args) 
    {
      // Add your code here:
      Person mike = new Person("Mike");
      Console.WriteLine (mike);
      mike.GrowOlder (5);
      Console.WriteLine (mike);
    }
  }
}