using Microsoft.AspNetCore.Mvc;
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
  }
}