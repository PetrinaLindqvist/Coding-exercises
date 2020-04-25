namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {
    private bool SensorOn;

    public TemperatureSensor()
    {
      this.SensorOn = false;
    }
    public bool IsOn()
    {
      return this.SensorOn;
    }


    public void SetOn()
    {
      this.SensorOn = true;
    }


    public void SetOff()
    {
      this.SensorOn = false;
    }


    public int Read()
    {
      if (IsOn())
      {
        return ;
      }
      else
      {
        throw new InvalidOperationException();
      }
    }
  }
}