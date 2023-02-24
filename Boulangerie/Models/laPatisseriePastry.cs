using System.Collections.Generic;

namespace Boulangerie.Models
{
  public class Pastry
  {

    private int _orderQuantity;
    public int OrderQuantity
    {
      get { return _orderQuantity; }
      set { _orderQuantity = value; }
    }
    static private int _pastryUnitCost = 2;
    static public int PastryUnitCost
    {
      get { return _pastryUnitCost; }
      set { _pastryUnitCost = value; }
    }

    public Pastry(int clientOrder)
    {
      _orderQuantity = clientOrder;
    }

    public int CalculatePastryCost()
    {
      int groupsOf4 = _orderQuantity / 4;
      int totalPastryCost = _pastryUnitCost * ((3 * groupsOf4) + (_orderQuantity-(groupsOf4) * 4));
      return totalPastryCost;
    }

  }
}
