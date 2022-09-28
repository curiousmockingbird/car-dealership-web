// using System;
// using System.Collections.Generic;

// namespace Dealership.Models 
// {
//   public class NewCar
//   {
//     public string NewMakeModel {get; set;}
//     public int NewPrice {get; set;}
//     public int NewMiles {get; set;}
//     public int NewTopSpeed {get; set;}
//     public int NewYear { get; set; }

//     private static List<NewCar> _newCars = new List<NewCar> {};

//     public NewCar(string newMakeModel, int newPrice, int newMiles, int newTopSpeed, int newYear)
//     {
//       NewMakeModel = newMakeModel;
//       NewPrice = newPrice;
//       NewMiles = newMiles;
//       NewTopSpeed = newTopSpeed;
//       NewYear = newYear;
//       _newCars.Add(this);
//     }

//     public static List<NewCar> GetAllNew()
//     {
//       return _newCars;
//     }
//   }
// }