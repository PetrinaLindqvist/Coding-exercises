namespace Exercise
{
  public class Teacher : Person
  {
    public int salary { get; set; }
  
    public Teacher(string name, string address, int salary) : base(name, address)
    {
      this.salary = salary;
    }

    public override string ToString()
    {
      return base.ToString() + " salary " + this.salary + " per month";
    } 
  }
}