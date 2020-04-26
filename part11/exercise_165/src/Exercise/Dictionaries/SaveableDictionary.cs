namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    private Dictionary<string, string> dictionary;
    public SaveableDictionary()
    {
      this.dictionary = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
  
    }

    public void Add(string word, string translation)
    {
      if (!dictionary.ContainsKey(word))
      {
        dictionary.Add(word, translation);
      }  
    }

    public bool Load()
    {
      return false;
    }

    public bool Save()
    {
      return false;
    }

    public string Translate(string word)
    {
      if (this.dictionary.ContainsKey(word))
      {
        return this.dictionary[word];
      }
      foreach (KeyValuePair<string, string> words in this.dictionary)
      {
        if (words.Value == word)
        {
          return words.Key;
        }
      }
      return null;  
    }

    public void Delete(string word)
    {
      foreach (KeyValuePair<string, string> words in this.dictionary)
      {
        if (words.Key == word | words.Value == word)
        {
          this.dictionary.Remove(words.Key);
        }
      }
    }
  }
}