using System;
// using System.Collections.Generic;

namespace ChopShop.Models
{
  public class Appointment
  {
    public string Name { get; set; }
    public string Time { get; set; }
    public string[] Service { get; set; }

    public Appointment(string name, string time, string service)
    {
      Name = name;
      Time = time;
      Service = new string[2] { "Haircut", "Moustache Groomin'" };
    }
  }
}