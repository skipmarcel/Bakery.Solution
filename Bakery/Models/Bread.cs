namespace Bakery.Models

{
 public class BreadDeal
 {
  private decimal _pricePerLoaf;
  private int _numLoaves;

  public BreadDeal(decimal pricePerLoaf, int numLoaves)
  {
   _pricePerLoaf = pricePerLoaf;
   _numLoaves = numLoaves;
  }

  public decimal GetTotalPrice()
  {
   int numPaidLoaves = _numLoaves / 3 * 2 + _numLoaves % 3;
   decimal totalPrice = numPaidLoaves * _pricePerLoaf;
   return totalPrice;
  }

 }
}
