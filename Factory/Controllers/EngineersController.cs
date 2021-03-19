using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class EngineersController: Controller
  {
    private readonly FactoryContext _db;
    public EngineersController(FactoryContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId)
    {

      bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == engineer.EngineerId && EngMach.MachineId == MachineId);
      if(!match) {
        _db.Engineers.Add(engineer);
        _db.SaveChanges();
        if(MachineId != 0)
        {
          _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = engineer.EngineerId, MachineId = MachineId });
        }
        _db.SaveChanges();
      }

      return RedirectToAction("Index");
    }

    public ActionResult Details(int engineerId)
    {
      Engineer thisEngineer = _db.Engineers
        .Include(engineer => engineer.JoinEntities)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(engineer => engineer.EngineerId == engineerId);
      return View(thisEngineer);
    }

    public ActionResult Edit(int engineerId)
    {
      Engineer thisEngineer = _db.Engineers
        .FirstOrDefault(engineer => engineer.EngineerId == engineerId);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer, int MachineId)
    {
      bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == engineer.EngineerId && EngMach.MachineId == MachineId);
      if(!match && MachineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = engineer.EngineerId, MachineId = MachineId });
      }
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details",new { engineerId = engineer.EngineerId });
    }
  }
}