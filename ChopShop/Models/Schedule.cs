using System;
using System.Collections.Generic;

namespace ChopShop.Models
{
  public class Schedule
  {
    public string Appointments { get; set; }
    public Schedule(string appointments)
    {
      Appointments = appointments;
    }
  }
}