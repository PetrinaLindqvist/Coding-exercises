namespace Exercise
{
  public class ProductWarehouseWithHistory : ProductWarehouse
  {
    public ChangeHistory changeHistory;
    public int initialBalance;
    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {
      this.initialBalance = initialBalance;
      this.changeHistory = new ChangeHistory();
      AddToWarehouse(initialBalance);
    }

    public string History()
    {
      return this.changeHistory.ToString();
    }

    new public void AddToWarehouse(int amount)
    {
      base.AddToWarehouse(amount);
      this.changeHistory.Add(this.balance);
    }

    new public int TakeFromWarehouse(int amount)
    {
      base.TakeFromWarehouse(amount);
      this.changeHistory.Add(this.balance);
      return amount;
    }
  }
}