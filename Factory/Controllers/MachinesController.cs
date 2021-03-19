using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;


namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    
    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {      
      if(machine.Name is null)
      {
        ViewBag.MachineId = new SelectList(_db.Engineers, "EngineerId", "Name");
        ViewBag.ErrorMessage = "Please enter a name.";
        return View();
      }
      else
      {
        bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == EngineerId && EngMach.MachineId == machine.MachineId);
        if(!match)
        {
          _db.Machines.Add(machine);
          _db.SaveChanges();
          if (EngineerId != 0)
          {
            _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
          }
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int machineId)
    {
      var thisMachine = _db.Machines
        .Include(machine => machine.JoinEntities)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(machine => machine.MachineId == machineId);

      return View(thisMachine);
    }
    
    public ActionResult Edit(int machineId)
    {
      Machine thisMachine = _db.Machines
        .FirstOrDefault(machine => machine.MachineId == machineId);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {      
      if(machine.Name is null)
      {
        ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
        ViewBag.ErrorMessage = "Please enter a name";
        return View(machine);
      }
      else
      {
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details",new { machineId = machine.MachineId });
      }
    }

    public ActionResult Delete(int MachineId)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == MachineId);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int MachineId)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == MachineId);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteEngineer(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      int machineId = joinEntry.Machine.MachineId;
      _db.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { machineId = machineId});
    }

    public ActionResult AddEngineer(int machineId)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == machineId);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int EngineerId)
    {
      bool match = _db.EngineerMachine.Any(EngMach => EngMach.EngineerId == EngineerId && EngMach.MachineId == machine.MachineId);
      if(!match && EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { machineId = machine.MachineId});
    }

  }
}