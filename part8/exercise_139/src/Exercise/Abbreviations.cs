using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    private Dictionary<string, string> directory;

        public Abbreviations()
    {
      this.directory = new Dictionary<string, string>();
    }
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      this.directory.Add(abbreviation, explanation);
    }

    public bool HasAbbreviation(string abbreviation)
    {
      if (this.directory.ContainsKey(abbreviation))
    {
      return true;
    }
    else
    {
      return false;
    }
      
    }

    public string FindExplanationFor(string abbreviation)
    {
      if (HasAbbreviation(abbreviation))
      {
        return this.directory[abbreviation];
      }
      else
      {
        return "not found";
      }
    }
  }
}