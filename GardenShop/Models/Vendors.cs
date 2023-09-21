using System.Collections.Generic;

namespace GardenShop.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }

    public Vendor (string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
    }
  }
}