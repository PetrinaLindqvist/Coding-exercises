namespace exercise_107
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
        this.balance = this.balance - 10.60;
    }

    public void DrinkCoffee()
    {
        this.balance = this.balance - 2.0;
    }

    public override string ToString()
    {
      // write code herepublic int count { get; set; }
        return("The card has a balance of " + this.balance + " euros");
    }
    
  }
}