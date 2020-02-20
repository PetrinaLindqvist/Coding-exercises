namespace exercise_124
{
  public class Person
  {
    private string name;
    private int age;

   public Person(string name)
   {
       this.name = name;
       this.age = 0;

   }
    public void GrowOlder(int number)
    {
        this.age++;
    }
    
    public override string ToString()
    {
      return this.name + this.age;
    }
  }
}