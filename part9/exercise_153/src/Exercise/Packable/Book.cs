namespace Exercise
{
  public class Book : IPackable
  {
      public string author;
      public string NameOfBook;
      public int publicationYear;
      public int weight;

    public Book(string author, string NameOfBook, int publicationYear)
    {
        this.author = author;
        this.NameOfBook = NameOfBook;
        this.publicationYear = publicationYear;
        this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.NameOfBook + " (" + this.publicationYear + ")";
    }
  }
}