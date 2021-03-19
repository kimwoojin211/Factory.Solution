using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
      this.Busy = false;
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public bool Busy { get; set; }
    public string YearsExperience { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}