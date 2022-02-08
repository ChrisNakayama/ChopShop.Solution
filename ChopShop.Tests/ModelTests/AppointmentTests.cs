using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ChopShop.Models;
using System;

namespace ChopShop.Tests
{
  [TestClass]
  public class AppointmentTests
  {
    [TestMethod]
      public void CreateNewAppointment()
      {
        Appointment newAppointment = new Appointment("name", "time", "service");
        Assert.AreEqual(typeof(Appointment), newAppointment.GetType());
      }
//     public void CheckIfAppointmentExists() 
//     {
//       Appointment testAppointment = new Appointment("name", "time", "service");
//       Assert.AreEqual(typeof(Appointment), testAppointment.GetType());
//     }

//     [TestMethod]
//     public void CheckAppointmentName() 
//     {
//       string name = "Test Name";
//       Appointment testAppointment = new Appointment(name, "time", "service");
//       Assert.AreEqual(testAppointment.Name, name);
//     }

//     [TestMethod]
//     public void CheckAppointmentTime() 
//     {
//       string time = "Test Time";
//       Appointment testAppointment = new Appointment("name", time, "service");
//       Assert.AreEqual(testAppointment.Time, time);
//     }

//     [TestMethod]
//     public void CheckAppointmentService() 
//     {
//       string service = "Test Service";
//       Appointment testAppointment = new Appointment("name", "time", service);
//       Assert.AreEqual(testAppointment.Service, service);
//     }
  }
}