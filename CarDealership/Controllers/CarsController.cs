using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Cars> allCars = Cars.GetAll();
      return View(allCars);
    }
    
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/cars/clear")]
    public ActionResult Clear()
    {
      Cars.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpPost("/cars")]
    public ActionResult Create(string carMakeAndModel, string carPrice)
    {
      Cars myCars = new Cars(carMakeAndModel, carPrice);
      return RedirectToAction("Index");
    }
  }
}