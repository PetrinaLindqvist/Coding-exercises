using System.Collections.Generic;
namespace Exercise
{
  public class Box : IPackable
  {
    public List<IPackable > list;
    public int i;
    public Box(int i)
    {
      this.i = i; 
      this.list = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if (Weight() + item.Weight() <= this.i)
      {
        list.Add(item);
      }
    }

    public int Weight()
    {
      int SumOfWeight = 0;
      foreach (IPackable item in list)
      {
        SumOfWeight = SumOfWeight + item.Weight();
      }
      return SumOfWeight;
    }

    public override string ToString()
    {
      return list.Count + " items, total weight " + Weight() + " kg";
    }
  }
}