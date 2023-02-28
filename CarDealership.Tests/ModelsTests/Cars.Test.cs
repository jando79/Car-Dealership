using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarsTests : IDisposable
  {

    public void Dispose()
    {
      Cars.ClearAll();
    }

    [TestMethod]
    public void CarsConstructor_CreatesInstanceOfCars_Cars()
    {
      Cars newCars = new Cars("test");
      Assert.AreEqual(typeof(Cars), newCars.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Car for sale.";

      //Act
      Cars newCars = new Cars(description);
      string result = newCars.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Car for sale.";
      Cars newCars = new Cars(description);

      //Act
      string updatedDescription = "Another car for sale";
      newCars.Description = updatedDescription;
      string result = newCars.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarsList()
    {
      // Arrange
      List<Cars> newList = new List<Cars> { };

      // Act
      List<Cars> result = Cars.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCars_CarsList()
    {
      //Arrange
      string description01 = "Car 01 for sale";
      string description02 = "Car 02 for sale";
      Cars newCars1 = new Cars(description01);
      Cars newCars2 = new Cars(description02);
      List<Cars> newList = new List<Cars> { newCars1, newCars2 };

      //Act
      List<Cars> result = Cars.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}