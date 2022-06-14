using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Controllers
{
  public class PackController : Controller
  {
    [HttpGet("/pack")]
    public ActionResult Index()
    {
      List<Pack> allPacks = Pack.GetAll();
      return View(allPacks);
    }
    [HttpPost("/pack")]
    public ActionResult Create(bool food, bool tent, bool water, bool bloodSacrifice)
    {
      System.Diagnostics.Debug.WriteLine(food);
      Pack newPack = new Pack(food,tent,water,bloodSacrifice);
      return RedirectToAction("Index");
    }
    [Route("/pack/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("pack/{id}")]
    public ActionResult Show(int id)
    {
      Pack foundPack = Pack.Find(id);
      return View(foundPack);
    }
    [HttpPost("pack/delete")]
    public ActionResult DeleteAll()
    {
      Pack.ClearAll();
      return View();
    }
  }
}