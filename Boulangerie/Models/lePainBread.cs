using System.Collections.Generic;
using System;

namespace Boulangerie.Models
{
  public class Bread
  {
    public int OrderQuantity { get; set; }
    static public int BreadUnitCost { get; set; } = 5;

    public Bread(int clientOrder)
    {
      OrderQuantity = clientOrder;
    }

    public int CalculateBreadCostFlatRate()
    {
      return BreadUnitCost * OrderQuantity;
    }

    public int CalculateBreadCost()
    {
      int groupsOf3 = OrderQuantity / 3;
      int totalBreadCost = BreadUnitCost * ((2 * groupsOf3) + (OrderQuantity-(groupsOf3) * 3));
      return totalBreadCost;
    }
  }
}
