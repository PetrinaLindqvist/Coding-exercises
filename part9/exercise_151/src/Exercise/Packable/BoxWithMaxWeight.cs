namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private List<Item> list;
    private int capacity;
    private int boxedItemsTotal;

    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.list = new List<Item>();
      this.boxedItemsTotal = 0;
    }

    public override void Add(Item item)
    {
      if (this.capacity - this.boxedItemsTotal >= item.weight)
      {
        list.Add(item);
        this.boxedItemsTotal += item.weight;
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