using System.Collections.Generic;

namespace Boulangerie.Models
{
  public class Bread
  {
    private int _orderQuantity;
    public int OrderQuantity
    {
      get { return _orderQuantity; }
      set { _orderQuantity = value; }
    }

    public Bread(int clientOrder)
    {
      _orderQuantity = clientOrder;
    }
  }
}
