namespace Exercise
{
  using System;
  public class Dog : Animal, INoiseCapable
  {

    public Dog() : this("Dog")
    {
   
    }

    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
      Console.WriteLine(this.name + " barks");
    }
    public void MakeNoise()
    {
      Bark();
    }

  }
}