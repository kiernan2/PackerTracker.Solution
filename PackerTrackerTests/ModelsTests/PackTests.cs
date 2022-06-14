using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.TestTools
{
  [TestClass]
  public class PackTests : IDisposable
  {
    public void Dispose()
    {
      Pack.ClearAll();
    }
    [TestMethod]
    public void PackConstructor_CreatesInstanceOfPlace()
    {
      Pack newPack = new Pack(true, true, true, true);
      Assert.AreEqual(typeof(Pack), newPack.GetType());
    }
    [TestMethod]
    public void PackCheckTrue()
    {
      Pack newPack = new Pack(true, true, true, true);
      Assert.AreEqual(newPack.Check(),true);
    }
    [TestMethod]
    public void PackCheckFalse()
    {
      Pack newPack = new Pack(true, true, true, false);
      Assert.AreEqual(newPack.Check(),false);
    }
  }
}