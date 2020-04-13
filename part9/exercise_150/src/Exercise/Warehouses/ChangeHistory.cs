namespace Exercise
{
  using System.Linq;
  using System.Collections.Generic;
  public class ChangeHistory 
  {
    private List<int> history;

    public ChangeHistory()
    {
      this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    public int MaxValue()
    {
      int Max = 0;
      if (this.history.Count > 0)
      {
        Max = this.history.Max();
      }
      return Max;
    }

    public int MinValue()
    {
      int Min = 0;
      if (this.history.Count > 0)
      {
        Min = this.history.Min();
      }
      return Min;
    }

    public override string ToString()
    {
      return "Current: " + this.history.Last() + " Min: " + MinValue() + " Max: " + MaxValue();
    }
  }
}
