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

 [TestMethod]
 public void GetTotalPrice_ReturnsCorrectTotalPriceForSevenLoavesOfBread()
 {
  //Arrange 
  decimal pricePerLoaf = 5.0m;
  int numLoaves = 7;
  BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

  //Act 
  decimal totalPrice = breadDeal.GetTotalPrice();

  //Assert should be equale because at 7 loaves total price is $25
  Assert.AreEqual(pricePerLoaf * 5, totalPrice);
 }

 [TestMethod]
 public void GetTotalPastryPrice_ShouldReturnCorrectPrice_WhenNumPastriesIs4()
 {
  //Arrange 
  decimal pricePerPastry = 2.0M;
  int numPastries = 4;
  decimal expectedPrice = 6.0M;
  PastryDeal pastryDeal = new PastryDeal(pricePerPastry, numPastries);

  //Act 
  decimal actualPrice = pastryDeal.GetTotalPastryPrice();

  //Assert
  Assert.AreEqual(expectedPrice, actualPrice);
 }

 [TestMethod]
 public void GetTotalPastryPrice_ShouldReturnCorrectPrice_WhenNumPastriesIs7()
 {
  //Arrange
  decimal pricePerPastry = 2.0M;
  int numPastries = 7;
  decimal expectedPrice = 12.0M;
  PastryDeal pastryDeal = new PastryDeal(pricePerPastry, numPastries);

  //Act
  decimal actualPrice = pastryDeal.GetTotalPastryPrice();

  //Assert
  Assert.AreEqual(expectedPrice, actualPrice);
 }
}
}
