namespace Exercise
{
  using System;
  public class Card : IComparable<Card>
  {
    public int value { get; }
    public Suit suit { get; }

    public Card(int value, Suit suit)
    {
      this.value = value;
      this.suit = suit;
    }

    public override string ToString()
    {
      if (this.value == 11)
      {
        return this.suit + " J";
      }
      
      else if (this.value == 12)
      {
        return this.suit + " Q";
      }
      else if (this.value == 13)
      {
        return this.suit + " K";
      }
      else if (this.value == 14)
      {
        return this.suit + " A";
      }
      else
      {
        return this.suit + " " + this.value;
      }
    }
    public int CompareTo(Card another)
    {
       if (another == null)
       {
        return 1;
       }
       
       if (this.value == another.value)
      {
        return this.suit.CompareTo(another.suit);
      }
      else if (this.value > another.value)
      {
        return 1;
      }
      else
      {
        return -1;
      }
      
    }
  }
}