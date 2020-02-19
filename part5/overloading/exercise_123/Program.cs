using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(5);
      
      
      counter.Increase();
      counter.Increase(4);
      counter.Decrease(6);
      Console.WriteLine(counter);
    
    
    }
  }
}
