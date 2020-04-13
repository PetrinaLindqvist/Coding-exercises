using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
    Warehouse wh = new Warehouse(100);
      Console.WriteLine(wh);
      wh.AddToWarehouse(10);
      Console.WriteLine(wh);
      wh.AddToWarehouse(100);
      Console.WriteLine(wh);
      wh.AddToWarehouse(-10);
      Console.WriteLine(wh);
      wh.TakeFromWarehouse(20);
      Console.WriteLine(wh);
      wh.TakeFromWarehouse(-20);
      Console.WriteLine(wh);

      Console.WriteLine();

      ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
      juice.AddToWarehouse(1000);
      juice.TakeFromWarehouse(11);
      Console.WriteLine(juice.productName); // Juice
      Console.WriteLine(juice);

      Console.WriteLine();

      ChangeHistory cs = new ChangeHistory();
      cs.Add(100);
      cs.Add(10);
      cs.Add(200);
      cs.Add(50);
      Console.WriteLine(cs);

      Console.WriteLine();

      ProductWarehouseWithHistory milk = new ProductWarehouseWithHistory("Milk", 1000, 100);
      Console.WriteLine(milk);
      milk.TakeFromWarehouse(10);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);
      milk.AddToWarehouse(100);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);
      milk.TakeFromWarehouse(-10000);
      Console.WriteLine(milk.History());
      Console.WriteLine(milk);
    }
  }
}
