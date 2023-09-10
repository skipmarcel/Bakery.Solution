namespace Bakery.Models
{
 public class PastryDeal
 {
  private decimal _pricePerPastry;
  private int _numPastries;

  public PastryDeal(decimal pricePerPastry, int numPastries)
  {
   _pricePerPastry = pricePerPastry;
   _numPastries = numPastries;
  }

  public decimal GetTotalPastryPrice()
  {
   int numPaidPastries = _numPastries / 4 * 3 + _numPastries % 4;
   decimal totalPrice = numPaidPastries * _pricePerPastry;
   return totalPrice;
  }
 }
}
