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
        if (this.jokes.Count == 0)
        {
            return "Jokes are in short supply.";
        }
        else
          {
            Random draw = new Random();
            int index = draw.Next(0, this.jokes.Count);
            return this.jokes[index];
          }
    
    
    } 
    public void PrintJokes()
    {
        foreach (string joke in this.jokes)
          {
            Console.WriteLine(joke);
          }
    }
  }
}