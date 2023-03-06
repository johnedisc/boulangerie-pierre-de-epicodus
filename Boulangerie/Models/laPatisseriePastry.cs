using System.Collections.Generic;

namespace Boulangerie.Models
{
  public class Pastry
  {

    public int OrderQuantity { get; set; }
    static public int PastryUnitCost { get; set; } = 2;

    public Pastry(int clientOrder)
    {
      OrderQuantity = clientOrder;
    }

    public int CalculatePastryCostFlatRate()
    {
      return PastryUnitCost * OrderQuantity;
    }

    public int CalculatePastryCost()
    {
      int groupsOf4 = OrderQuantity / 4;
      int totalPastryCost = PastryUnitCost * ((3 * groupsOf4) + (OrderQuantity-(groupsOf4) * 4));
      return totalPastryCost;
    }

  }
}
