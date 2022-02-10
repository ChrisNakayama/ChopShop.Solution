Chop Shop

The Program Will:

• Code includes two custom classes and uses namespaces.
• Console application works correctly.
• Application correctly uses auto-implemented properties.
• Classes should include methods for determining the price of an order.
• Models are thoroughly tested.
• Project is in a polished, portfolio-quality state.
• The prompt’s required functionality and baseline project requirements are in place by the deadline.

Class one = Appointment Book = ```Schedule.cs```
 - Create function
 - Search function
 - Delete function (stretch)

Class two = Appointments = ```Appointments.cs```
 - Name
 - Time
 - Service 1 + cost (Haircut) = ```Haircut.cs```
 - Service 2 + cost (Mustache groom) = ```Mustache.cs```
 Include methods for determining the price of an order.
 - - Sale on one item, or 10% off any two services selected.
 - Calculate Final Cost = FinalCost.cs 

 Assessment for 2.8.2022

 Constructor that builds Appointments = (name, time, service)


 AppointmentTests.cs (commented out)
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

 