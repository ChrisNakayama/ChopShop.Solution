using System;
using System.Collections.Generic;
using ChopShop.Models;

//-----------------------from Car Dealership----------------------
namespace ChopShop.Models {

  public class Program
  {
    public static void Main()
    {
      Appointment john = new Appointment("John Whitten", "2:00pm", "Haircut");
      
      List<Appointment> Appointments = new List<Appointment>() {john };

     

      // yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.SalePrice(.75));
        Console.WriteLine(automobile.MakeSound());
        Console.WriteLine("Dakar Ralley outlook? " + automobile.DakarOutlook);
      }
    }
  }

}