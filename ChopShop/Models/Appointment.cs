using System;

namespace ChopShop.Models
{
  public class Appointment
  {
    public string Name { get; set; }
    public string Time { get; set; }

    public Appointment(string name, string time)
    {
      Name = name;
      Time = time;
    }
  }
}