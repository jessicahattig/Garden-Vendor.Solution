using Microsoft.VisualStudio.TestTools.UnitTesting;
using GardenShop.Models;
using System.Collections.Generic;
using System;

namespace GardenShop.TestTools
{
  [TestClass]
  public class VendorsTests 
  {
    [TestMethod]
    public void VategoryConstructor_CreatesInstanceOfVendor_Vendor()
    {
      VendorsTests newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}