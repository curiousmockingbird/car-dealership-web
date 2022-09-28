using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;

namespace Cars.Controllers
{
  public class CarsController : Controller
  {
    // [HttpGet("/home")]
    // public ActionResult Index()
    // {
    //   return View();
    // }

    [HttpGet("/cars")]
    public ActionResult Cars()
    {
      Dictionary<string,dynamic> Models = new Dictionary<string,dynamic> ();

      List<NewCar> allNewCars = NewCar.GetAllNew();
      List<Car> allCars = Car.GetAll();

      Models.Add("AllNewCars", allNewCars);
      Models.Add("AllCars", allCars);

      return View(Models);
    }

    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/cars/{id}")]
    public ActionResult Show(int id)
    {
      Car foundCar = Car.Find(id);
      return View(foundCar);
    } 


    [HttpPost("/cars")]
    public ActionResult Create(string newMakeModel, int newPrice, int newMiles, int newTopSpeed, int newYear)
    {
      NewCar newCar = new NewCar(newMakeModel, newPrice, newMiles, newTopSpeed, newYear);
      List<NewCar> allNewCars = NewCar.GetAllNew();
      return RedirectToAction("Cars", allNewCars);
    }

  }
}