using Microsoft.VisualStudio.TestTools.UnitTesting;
using GardenShop.Models;
using System.Collections.Generic;
using System;

namespace GardenShop.Tests
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VategoryConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}