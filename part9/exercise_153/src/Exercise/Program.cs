using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
      Book book2 = new Book("Robert Martin", "Clean Code", 2008);
      Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

      Furniture sofa = new Furniture("Sofa", "Red", 20);
      Furniture bed = new Furniture("Twin bed", "White", 15);
      Furniture table = new Furniture("Dining room table", "Oak", 30);

      Box bookBox = new Box(5);
      bookBox.Add(book1);
      bookBox.Add(book2);
      bookBox.Add(book3);

      Console.WriteLine(bookBox);
      Console.WriteLine();

      Box movingVan = new Box(800);
      movingVan.Add(bookBox);
      movingVan.Add(sofa);
      movingVan.Add(bed);
      movingVan.Add(table);

      Console.WriteLine(movingVan);
      Console.WriteLine();

      Box shippingContainer = new Box(3000);
      shippingContainer.Add(movingVan);

      Console.WriteLine(shippingContainer);
    }
  }
}
