using System.Collections.Generic;

namespace Factory.Models
{
  public class EngineerMachine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId {get; set;}

    public virtual ICollection<EngineerMachine> JoinEntities {get; }
  }
}