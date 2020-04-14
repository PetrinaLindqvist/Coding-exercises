namespace Exercise
{
  using System.Linq;
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    public List<Item> list;
    private int capacity;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.list = new List<Item>();
    }

    public override void Add(Item item)
    {
      if (item.weight < this.capacity)
      {
        list.Add(item);
      }
      
      
    }


    public override bool IsInBox(Item item)
    {
      if (list.Contains(item))
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }
  }
}