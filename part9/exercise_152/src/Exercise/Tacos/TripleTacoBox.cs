namespace Exercise
{
  public class TripleTacoBox : ITacoBox
  {
     private int tacos;
    
    public TripleTacoBox()
    {
      this.tacos = 3;
    }
    public int TacosRemaining()
    {
       return this.tacos;
    }

    public void Eat()
    {
      if (this.tacos > 0)
      {
        this.tacos = this.tacos -1;
      }
    }
  }
}