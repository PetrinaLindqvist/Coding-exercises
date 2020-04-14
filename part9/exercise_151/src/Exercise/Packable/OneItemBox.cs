namespace Exercise
{
  using System.Collections.Generic;
  public class OneItemBox : Box
  {
    private List<Item> list;

    public OneItemBox()
    {
      this.list = new List<Item>();
    }

    public override void Add(Item item)
    {
      if (list.Count == 0)
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