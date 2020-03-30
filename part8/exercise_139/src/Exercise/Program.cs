using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Abbreviations abbreviations = new Abbreviations();
      abbreviations.AddAbbreviation("e.g", "for example");
      abbreviations.AddAbbreviation("etc.", "and so on");
      abbreviations.AddAbbreviation("i.e", "more precisely");

      string text = "e.g etc. i.e lol";

      foreach (string part in text.Split(" "))
      {
        Console.WriteLine(abbreviations.FindExplanationFor(part));
      }
    }
  }
}
