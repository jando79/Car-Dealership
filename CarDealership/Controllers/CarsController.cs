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

    [HttpPost("/cars")]
    public ActionResult Create(string description, string carPrice)
    {
      Cars myCars = new Cars(description, carPrice);
      return RedirectToAction("Index");
    }
  }
}