namespace Exercise
{
  using System;
  using System.Collections.Generic;
  
  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      if (this.numbers.Contains(number))
      {
        return true;
      }// Draw and print a random number
      else
      {
        return false;
      }
    }
    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
     Random lotteryNbr = new Random();
     while (this.numbers.Count < 7)
     {
       int number = lotteryNbr.Next(1, 41);
       if(!this.ContainsNumber(number))
       {
         this.numbers.Add(number);
       }
     }
     this.numbers.Sort();
     
    
    
    }

  }
}