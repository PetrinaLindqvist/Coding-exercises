namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;
    public Hand()
    {
      this.hand = new List<Card>();
    }
    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);
      }
    }

    public void Print()
    {
      foreach (Card card in this.hand)
      {
        Console.WriteLine(card.ToString());
      }
      
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      int SumOfHand1 = 0;
      foreach (Card card in this.hand)
      {
        SumOfHand1 += card.value;
      }
      int SumOfHand2 = 0;
      foreach (Card card in hand.hand)
      {
        SumOfHand2 += card.value;
      }
      if (SumOfHand1 == SumOfHand2)
      {
        return 0;
      }
      else if (SumOfHand1 > SumOfHand2)
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