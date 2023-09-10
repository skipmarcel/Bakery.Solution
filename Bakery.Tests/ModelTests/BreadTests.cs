using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
 [TestClass]
 public class BreadTests
 {

  [TestMethod]
  public void GetTotalPrice_ReturnsCorrectTotalPriceForOneLoafOfBread()
  {
   //Arrange 
   decimal pricePerLoaf = 5.0m;
   int numLoaves = 1;
   BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

   //Act
   decimal totalPrice = breadDeal.GetTotalPrice();

   //Assert should be the same becaue it's only one loaf
   Assert.AreEqual(pricePerLoaf, totalPrice);
  }

  [TestMethod]
  public void GetTotalPrice_ReturnsCorrectTotalPriceForTwoLoafOfBread()
 {
  //Arrange 
  decimal pricePerLoaf = 5.0m;
  int numLoaves = 2;
  BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

  //Act
  decimal totalPrice = breadDeal.GetTotalPrice();

  //Assert should be equal because price is multiplied by 2
  Assert.AreEqual(pricePerLoaf * 2, totalPrice);
 }
}
}
