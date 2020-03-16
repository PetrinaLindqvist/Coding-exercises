using System;
using System.Collections.Generic;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<Person> kindergarten = new List<Person>();
      
      Person mike = new Person("Mike");
      Person lily = new Person("Lily");
      
      kindergarten.Add(mike);
      kindergarten.Add(lily);
      
      lily.GrowOlder(1);
     
    foreach (Person child in kindergarten) 
    {
      Console.WriteLine(child);
    }
      
    }
    
  }
}
