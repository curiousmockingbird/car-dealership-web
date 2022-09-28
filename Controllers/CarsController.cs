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
      List<Car> allCars = Car.GetAll();
      return View(allCars);
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


    /* [HttpPost("/cars")]
    public ActionResult Create(string newMakeModel, int newPrice, int newMiles, int newTopSpeed, int newYear)
    {
      NewCar newCar = new NewCar(newMakeModel, newPrice, newMiles, newTopSpeed, newYear);
      List<NewCar> allNewCars = NewCar.GetAllNew();
      return RedirectToAction("Cars", allNewCars);
    } */

  }
}