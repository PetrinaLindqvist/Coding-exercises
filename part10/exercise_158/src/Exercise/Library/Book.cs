namespace Exercise
{
  using System;
  public class Book : IComparable<Book>
  {

    public string name { get; set; }
    public int age { get; set; }

    public Book(string name, int age)
    {
      // Fill in the blanks
      this.name = name;
      this.age = age;
    }


    public override string ToString()
    {
      // Don't touch this
      return this.name + " (recommended for " + this.age + " year-olds or older)";
    }


    public int CompareTo(Book other)
    {

      // Do some magic here
       // If compared book is null, return 1
      // "this" comes after null
      if (other == null)
      {
        return 1;
      }
      // If height is equal, return 0
      // They are now equal in comparison
      if (this.age == other.age)
      {
        return this.name.CompareTo(other.name);
      }
      // If this height is more
      // Return 1
      // "this" comes after compared member
      else if (this.age > other.age)
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
    

  }
}