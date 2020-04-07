using System;
using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
     private Dictionary<string, List<string>> translations;
     
    public DictionaryOfManyTranslations()
    {    
      this.translations = new Dictionary<string, List<string>>();
    }
    public void Add(string word, string translation)
    {
      if (!this.translations.ContainsKey(word)) 
      {
        this.translations.Add(word, new List<string>());
      }
      this.translations[word].Add(translation);
    }

    public List<string> Translate(string word)
    {
      if (!this.translations.ContainsKey(word))
      {
      this.translations.Add(word, new List<string>());
      }
      return this.translations[word];
    }
    public void Remove(string word)
    {
       if (this.translations.ContainsKey(word)) 
      {
        this.translations.Remove(word);
      }
      
    }
  }
}