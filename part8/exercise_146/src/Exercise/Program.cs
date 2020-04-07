using System;
using System.Collections.Generic;

namespace Exercise 
{
  public class Program 
  {
    public static void Main(string[] args) 
    {
      DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
      dictionary.Add("lie", "maata");
      dictionary.Add("lie", "valehdella");

      dictionary.Add("bow", "jousi");
      dictionary.Add("bow", "kumartaa");

      foreach (string translation in dictionary.Translate ("bow")) 
      {
        Console.WriteLine (translation);
      }
      Console.WriteLine();

      foreach (string translation in dictionary.Translate ("lie"))
      {
        Console.WriteLine (translation);
      }

      dictionary.Remove("bow");
      foreach (string translation in dictionary.Translate ("bow"))
      {
        Console.WriteLine (translation);
      }
    }
  }
}