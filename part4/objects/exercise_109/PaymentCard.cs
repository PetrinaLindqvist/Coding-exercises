namespace exercise_109
{
  public class PaymentCard
  {
     private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
        this.balance = openingBalance;
    }

    public void EatLunch()
    {
        if (this.balance -10.60 > 0)
        {
            this.balance = this.balance - 10.60;
        }
        
    }

    public void DrinkCoffee()
    {
        if (this.balance -2.0 > 0)
        {
            this.balance = this.balance - 2.0;
        }
    }

    public void AddMoney(double amount) 
    {
    // write code here
        if (amount > 0)
        {
            this.balance = this.balance + amount;
        }
        if (amount > 150)
        {
            this.balance = 150;
        }
    
    }
    
    
    public override string ToString()
    {
      // write code herepublic int count { get; set; }
        return("The card has a balance of " + this.balance + " euros");
    }
    
  }
}