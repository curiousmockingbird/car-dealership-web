using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("Volkswagen Thing", 1100, 368792, 80, 1974);
      Car yugo = new Car("Yugo Koral", 1200, 56000, 90, 1980);
      Car ford = new Car("Ford Country Squire", 1400, 239001, 100, 1988);
      Car amc = new Car("AMC Pacer", 900, 198000, 40, 1976);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

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
        Console.WriteLine("Year: " + automobile.GetYear());       
        Console.WriteLine("Original Price: $" + automobile.GetPrice());
        Console.WriteLine("Sale Price: $" + (automobile.GetPrice() * .8));
        Console.WriteLine("Resale Value: $" + automobile.Resale());
        Console.WriteLine("Top Speed: " + automobile.GetSpeed() + " mph");
        Console.WriteLine("For Dakar Rally this is a " + automobile.Placement());
      }
    }
  }
}