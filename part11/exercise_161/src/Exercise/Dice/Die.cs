namespace Exercise
{
  using System;
  public class Die
  {
    private Random random;
    private int numberOfFaces;

    public Die(int numberOfFaces)
    {
      this.random = new Random();
     
      // Initialize the value of numberOfFaces here
      this.numberOfFaces = numberOfFaces;
    }
    public int ThrowDie()
    {
        // Draw and print a random number
        int randomNumber = random.Next(1, numberOfFaces + 1);
        return randomNumber;
        // generate a random number which may be any number
        // between one and the number of faces, and then return it
      

      // generate a random number which may be any number
      // between one and the number of faces, and then return it
   
    }
    
  }
}