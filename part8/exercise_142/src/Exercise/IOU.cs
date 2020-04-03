using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> dictionary;
    public IOU()
    {
      this.dictionary = new Dictionary<string, int>();
    }
    public void ChangeDebt(string toWhom, int amount)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        int newAmount = this.dictionary[toWhom] + amount;
        if (newAmount > 0)
        {
          this.dictionary[toWhom] = newAmount;
        }
        else
        {
          this.dictionary[toWhom] = 0;
        }
      }
      else if (amount > 0)
      {
        this.dictionary[toWhom] = amount;
      }
      else
      {
        this.dictionary[toWhom] = 0;
      }
      
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        return this.dictionary[toWhom];
      }
      else
      {
        return 0;
      }
    }
    
  }
}
