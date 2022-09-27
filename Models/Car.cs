using System;
using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    public int TopSpeed {get; set;}
    public int Year { get; set; }

    private static List<Car> _cars = new List<Car> {};

    public Car(string makeModel, int price, int miles, int topSpeed, int year)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      TopSpeed = topSpeed;
      Year = year;
      _cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }

    public static void ClearAll()
    {
      _cars.Clear();
    }
  }
}