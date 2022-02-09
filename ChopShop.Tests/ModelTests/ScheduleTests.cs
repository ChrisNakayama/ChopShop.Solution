using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ChopShop.Models;
using System;

namespace ChopShop.Tests
{
  [TestClass]
  public class ScheduleTests
  {
    [TestMethod]
      public void CreateSchedule()
      {
        Schedule newSchedule = new Schedule("Appointment");
        Assert.AreEqual(typeof(Schedule), newSchedule.GetType());
      }
  }
}