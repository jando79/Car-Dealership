using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpPost("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}