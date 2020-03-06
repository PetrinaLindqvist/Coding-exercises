using System;
using System.Collections.Generic;

namespace exercise_135
{
  public class JokeManager
  {

    private List<string> jokes;

    public JokeManager()
    {
        this.jokes = new List<string>();
    }
  
    public void AddJoke(string joke)
    {
      this.jokes.Add(joke);
    }
    public string DrawJoke()
    {
        if (jokes.Count == 0)
        {
            return "Jokes are in short supply.";
        }
        else
          {
            Random draw = new Random();
            int index = draw.Next(0, jokes.Count);
            return jokes[index];
          }
    
    
    } 
    public void PrintJokes()
    {
        foreach (string joke in jokes)
          {
            Console.WriteLine(joke);
          }
    }
  }
}