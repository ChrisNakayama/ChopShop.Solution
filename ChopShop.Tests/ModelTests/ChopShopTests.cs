using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChopShop;

namespace ChopShop.Tests
{
  [TestClass]
  public class AppointmentTests
  {
    // Test methods go here
    [TestMethod]
    public void CheckIfAppointmentExists() 
    {
      Appointment TestAppointment = new Appointment();
      Assert.IsNotNull(TestAppointment);
    }
  }
}
