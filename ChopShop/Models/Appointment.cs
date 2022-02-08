using System;
using System.Collections.Generic;

namespace ChopShop.Models
{
  public class Appointment
  {
    public string Name { get; set; }
    public string Time { get; set; }
    // public string Service { get; set; }

    // public Appointment(string Name, string Time, string Service)
    public Appointment(string name, string time)
    {
      Name = name;
      Time = time;
      // Service = service;
    }
  }
}