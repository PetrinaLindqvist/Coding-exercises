namespace Exercise
{
  using System;
  public class Cat : Animal, INoiseCapable
  {

    public Cat() : this("Cat")
    {
    }

    public Cat(string name) : base(name)
    {
    }

    public void Purr()
    {
      Console.WriteLine(this.name + " purrs");
    }
    public void MakeNoise()
    {
      Purr();
    }

  }
}