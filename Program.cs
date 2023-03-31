using Strategy.Business.Models;
using System;

namespace Strategy
{
  class Program
  {
    static void Main(string[] args)
    {
      var order = new Order
      {
        ShippingDetails = new ShippingDetails
        {
          OriginCountry = "Luxembourg",
          DestinationCountry = "Luxembourg"
        }
      };

      order.LineItems.Add(new Item("01234", "C# dans ta face", 100m, ItemType.Literature), 1);
      order.LineItems.Add(new Item("56780", "Consulting Cybersécurité", 100m, ItemType.Service), 1);

      Console.WriteLine(order.GetTax());
    }
  }
}
