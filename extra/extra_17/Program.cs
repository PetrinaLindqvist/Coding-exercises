using System;
using System.Collections.Generic;
namespace extra_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<String> list = new List<String>();
       
        while (true)
        {
          Console.WriteLine("Identifying number?");
          string number = (Console.ReadLine());
        
        if (number == "")
        {
          break;
        }
        
        Console.WriteLine("Name? (empty will stop):");
        string name = Console.ReadLine();

        if (name == "")
        {
          break;
        }
       
        
        String identity = new String(number, name);
        if (list.Contains(identity))
        {
          list.Add(identity);
        }
        
      }
        Console.WriteLine("==Persons==");
        foreach(String identity in list)
        {
          Console.WriteLine(identity);
        }
       
      }
    }
  }

