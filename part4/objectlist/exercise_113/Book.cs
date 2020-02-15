using System;

namespace exercise_113

{
  
  public class Book
  {

    public string title { get; set; }
    public int pages { get; set; }
    public string publicationYear { get; set; }

    public Book(string title, int pages, string publicationYear)
    {
      this.title = title;
      this.pages = pages;
      this.publicationYear = publicationYear;
    }

    public override string ToString()
    {
      return this.title + ", " + this.pages + " pages, " + this.publicationYear;
    }
  }
}