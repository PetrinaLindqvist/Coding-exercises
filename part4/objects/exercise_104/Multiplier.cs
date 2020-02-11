namespace exercise_104 {
  public class Multiplier 
  {
    public int number { get; set; } 
    

     public Multiplier(int number)
     {
      this.number = number;
     }

     public int Multiply(int number)
     {
      // Should return for example "My name is Bond. James Bond."
       this.number = this.number * number;
       return this.number;
     }
  }
}