namespace Exercise
{
  public class Furniture : IPackable
  {
    public string typeOfFurniture;
    public string color;
    public int weight;
    
    public Furniture(string typeOfFurniture, string color, int weight)
    { 
        this.typeOfFurniture = typeOfFurniture;
        this.color = color;
        this.weight = weight;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.typeOfFurniture + " -" + " weight " + this.weight + " kg";
    }
  }
}