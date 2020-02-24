namespace exercise_132
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public void Advance()
    {
      // Do something here
    this.day++;
    
      if (this.day > 30)
            {
                this.month++;
                this.day = 1;
            }

            if (this.month > 12)
            {
                this.year++;
                this.month = 1;
            }
    }

    public void Advance(int howManyDays)
    {
      // Do something here
      for (int i = 0; i < howManyDays; i++)
            {
                this.Advance();
            }
    }

    public SimpleDate AfterNumberOfDays(int days)
    {
      SimpleDate newDate = new SimpleDate( this.day, this.month, this.year);
      // Do something here
      newDate.Advance(days);
      return newDate;
    }


    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    // used to check if this date object (`this`) is before
    // the date object given as the parameter (`compared`)
    public bool Before(SimpleDate compared)
    {
      // first compare years
      if (this.year < compared.year)
      {
        return true;
      }

      // if the years are the same, compare months
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }

      // the years and the months are the same, compare days
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }

      return false;
    }
  }
}