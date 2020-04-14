using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BoxWithMaxWeight coffeeBox = new BoxWithMaxWeight(10);
      coffeeBox.Add(new Item("Saludo", 5));
      coffeeBox.Add(new Item("Pirkka", 5));
      coffeeBox.Add(new Item("Kopi Luwak", 5));

      Console.WriteLine(coffeeBox.IsInBox(new Item("Saludo")));
      Console.WriteLine(coffeeBox.IsInBox(new Item("Pirkka")));
      Console.WriteLine(coffeeBox.IsInBox(new Item("Kopi Luwak")));

      OneItemBox box = new OneItemBox();
      box.Add(new Item("Saludo", 5));
      box.Add(new Item("Pirkka", 5));

      Console.WriteLine(box.IsInBox(new Item("Saludo")));
      Console.WriteLine(box.IsInBox(new Item("Pirkka")));

      MisplacingBox mbox = new MisplacingBox();
      Console.WriteLine(mbox.IsInBox(new Item("Saludo")));
      Console.WriteLine(mbox.IsInBox(new Item("Pirkka")));
    }
  }
}
