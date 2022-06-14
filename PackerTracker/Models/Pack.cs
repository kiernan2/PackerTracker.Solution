using System.Collections.Generic;
using System;

namespace PackerTracker.Models
{
  public class Pack
  {
    public bool Food { get; set; }
    public bool Tent { get; set; }
    public bool Water { get; set; }
    public bool BloodSacrifice { get; set; }
    public int Id { get; }
    private static List<Pack> _instances = new List<Pack>();
    public Pack (bool food, bool tent, bool water, bool bloodSacrifice)
    {
      Food = food;
      Tent = tent;
      Water = water;
      BloodSacrifice = bloodSacrifice;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public bool Check()
    {
      if (this.Food == true && this.Tent == true && this.Water == true && this.BloodSacrifice == true)
      {
        return true;
      } else
      {
        return false;
      }
    }
    public static Pack Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static List<Pack> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}