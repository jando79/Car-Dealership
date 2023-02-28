using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Cars
  {
    public string CarPrice { get; set; }
    public string Description { get; set; }
    private static List<Cars> _instances = new List<Cars> { };

    public Cars(string carMakeAndModel)
    {
      Description = carMakeAndModel;
      _instances.Add(this);
    }

    public Cars(string carMakeAndModel, string carPrice)
    {
      CarPrice = carPrice;
      Description = carMakeAndModel;
      _instances.Add(this);
    }

    public static List<Cars> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}