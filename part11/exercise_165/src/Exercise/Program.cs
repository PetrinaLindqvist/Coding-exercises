namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      SaveableDictionary dictionary = new SaveableDictionary();
      dictionary.Add("apina", "monkey");
      dictionary.Add("banaani", "banana");
      dictionary.Add("apina", "apfe");
      dictionary.Add("ohjelmointi", "programming");

      dictionary.Delete("apina");
      dictionary.Delete("banana");

      Console.WriteLine(dictionary.Translate("apina"));
      Console.WriteLine(dictionary.Translate("monkey"));
      Console.WriteLine(dictionary.Translate("banana"));
      Console.WriteLine(dictionary.Translate("banaani"));
      Console.WriteLine(dictionary.Translate("ohjelmointi"));
    }
  }
}
