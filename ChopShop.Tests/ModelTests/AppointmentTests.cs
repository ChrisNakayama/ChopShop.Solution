using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChopShop.Models;

namespace ChopShop.Tests
{
  [TestClass]
  public class AppointmentTests
  {
    [TestMethod]
      public void CreateNewAppointment()
      {
        Appointment newAppointment = new Appointment("name", "time");
        Assert.AreEqual(typeof(Appointment), newAppointment.GetType());
      }

  }
}