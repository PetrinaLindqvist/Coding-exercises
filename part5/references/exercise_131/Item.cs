namespace exercise_131
{
  public class Item
  {

    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }
    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

    public override bool Equals(object compared)
    {

      //compare with Item.identifier
       if (this == compared)
      {
        return true;
      }

      // if the compared object is null, or
      // if the type of the compared object is not SimpleDate, the objects are not equal
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }

      // convert the Object type compared object
      // into an SimpleDate type object called comparedSimpleDate
      Item comparedItem = (Item)compared;

      // if the values of the object variables are the same, the objects are equal
      if (this.identifier == comparedItem.identifier) 
      { 
        return true;
      }

      // otherwise the objects are not equal
      return false;
     
    }

  }
}