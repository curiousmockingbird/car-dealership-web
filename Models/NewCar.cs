using System;
using System.Collections.Generic;

namespace Dealership.Models 
{
  public class NewCar
  {
    public string NewMakeModel {get; set;}
    public int NewPrice {get; set;}
    public int NewMiles {get; set;}
    public int NewTopSpeed {get; set;}
    public int NewYear { get; set; }

    public int NewId { get; }

    private static List<NewCar> _newCars = new List<NewCar> {};

    public NewCar(string newMakeModel, int newPrice, int newMiles, int newTopSpeed, int newYear)
    {
      NewMakeModel = newMakeModel;
      NewPrice = newPrice;
      NewMiles = newMiles;
      NewTopSpeed = newTopSpeed;
      NewYear = newYear;
      _newCars.Add(this);
      NewId = _newCars.Count;
    }
    public static NewCar Find(int searchNewId)
    {
      return _newCars[searchNewId - 1];
    }
    public static List<NewCar> GetAllNew()
    {
      return _newCars;
    }
  }
}