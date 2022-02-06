using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChopShop;

namespace ChopShop.Tests
{
  [TestClass]
  public class AppointmentTests
  {
    [TestMethod]
    public void CheckIfAppointmentExists() 
    {
      Appointment TestAppointment = new Appointment("1");
      Assert.IsNotNull(TestAppointment);
    }
    [TestMethod]
    public void CheckIfObjectsAreTheSame() 
    {
      Appointment TestAppointment = new Appointment("1");
      Assert.AreEqual(typeof(Appointment), TestAppointment.GetType());
    }
    [TestMethod]
    public void PassAndReturnString()
    {
      // Arrange
      string name = "test string";
      Appointment TestAppointment = new Appointment(name);

      // Act
      TestAppointment.Name = name;
      string result = TestAppointment.Name;

      // Assert
      Assert.AreEqual(name, result));
    }
  }
}
