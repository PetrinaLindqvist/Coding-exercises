namespace Exercise
{
  using System;
  public class Human : IComparable<Human>
  {

    public int wage { get; }
    public string name { get; }

    public Human(string name, int wage)
    {
      this.name = name;
      this.wage = wage;
    }

    public int CompareTo(Human another)
    {
      // BEGIN SOLUTION
      // If wage is equal, return 0
      // They are now equal in comparison
      if (this.wage == another.wage)
      {
        return 0;
      }
      // If this wage is less
      // Return 1
      // "this" comes after compared member
      else if (this.wage < another.wage)
      {
        return 1;
      }
      // As all other options have been done
      // Return -1
      // "this" comes before compared member
      else
      {
        return -1;
      }
    
    }


    public override string ToString()
    {
      return name + " " + wage;
    }
  }
}