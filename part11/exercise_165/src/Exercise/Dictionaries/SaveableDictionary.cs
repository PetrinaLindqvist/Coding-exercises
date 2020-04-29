namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    private Dictionary<string, string> dictionary;
    private string file;

    public SaveableDictionary()
    {
      this.dictionary = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      if (!this.dictionary.ContainsKey(word))
      {
        this.dictionary.Add(word, translation);
        this.dictionary.Add(translation, word);
      }  
    }

    public bool Load()
    {
      try
      {
        string[] lines = File.ReadAllLines(this.file);
        foreach (string line in lines)
        {
          string[] parts = line.Split(":");
          string word = parts[0];
          string translation = parts[1];
          Add(word, translation);
        }
              
      }  
      catch 
      {
        return false;
      }
      return true;
    }

    public bool Save()
    {
      List<string> alreadySaved = new List<string>();
      try
      {
        StreamWriter sw = new StreamWriter(this.file);
        foreach (string word in this.dictionary.Keys) 
        {
          string composition = word + ":" + this.dictionary[word];
          string backwards = this.dictionary[word] + ":" + word;
          if (!alreadySaved.Contains(composition)&& !alreadySaved.Contains(backwards))
          {
            alreadySaved.Add(composition);
            sw.WriteLine(composition);
          }
        }
      sw.Close();
      }
      catch
      {
        return false;
      }
      return true;
      
    }

    public string Translate(string word)
    {
      if (this.dictionary.ContainsKey(word))
      {
        return this.dictionary[word];
      }
      return null;  
    }

    public void Delete(string word)
    {
        if (this.dictionary.ContainsKey(word))
        {
          string translation = this.dictionary[word];
          this.dictionary.Remove(word);
          this.dictionary.Remove(translation);
        }
    }
    
  }
}