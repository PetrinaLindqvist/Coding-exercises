namespace Exercise
{
  using System;
  public abstract class Animal
  {
    public string name { get; } 
    public Animal(string name)
    {
      this.name = name;
    }

    public void Eat()
    {
      Console.WriteLine(this.name + " eats");
    }

    public void Sleep()
    {
      Console.WriteLine(this.name + " sleeps");
    }

  }
}