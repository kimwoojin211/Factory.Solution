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
    public ActionResult Create(Engineer engineer, int machineId)
    {
      System.Console.WriteLine(engineer.Name);
      if(engineer.Name is null)
      {
        ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
        ViewBag.ErrorMessage = "Please enter a name";
        return View();
      }
      else
      {
        bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == engineer.EngineerId && EngMach.MachineId == machineId);
        if(!match) 
        {
          _db.Engineers.Add(engineer);
          _db.SaveChanges();
          if(machineId != 0)
          {
            _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = engineer.EngineerId, MachineId = machineId });
          }
          _db.SaveChanges();
          
        }
      return RedirectToAction("Index");
      }
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
    public ActionResult Edit(Engineer engineer)
    {      
      if(engineer.Name is null)
      {
        ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
        ViewBag.ErrorMessage = "Please enter a name";
        return View(engineer);
      }
      else
      {
        _db.Entry(engineer).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Details",new { engineerId = engineer.EngineerId });
      }
    }

    public ActionResult Delete(int engineerId)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == engineerId);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int engineerId)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == engineerId);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      int engineerId = joinEntry.Engineer.EngineerId;
      _db.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { engineerId = engineerId});
    }

    public ActionResult AddMachine(int engineerId)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == engineerId);
      ViewBag.MachineId = new SelectList(_db.Machines,"MachineId","Name");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int machineId)
    {
      bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == engineer.EngineerId && EngMach.MachineId == machineId);
      if(!match && machineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = engineer.EngineerId, MachineId = machineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { engineerId = engineer.EngineerId});
    }
  }
}