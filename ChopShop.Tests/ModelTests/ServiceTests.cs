using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChopShop.Models;

namespace ChopShop.Tests
{
  [TestClass]
  public class ServiceTests
  {
    [TestMethod]
      public void addService()
      {
        Service newService = new Service(55, 65);
        Assert.AreEqual(typeof(Service), newService.GetType());
      }
  }
}