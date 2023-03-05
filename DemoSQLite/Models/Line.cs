using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Models
{
  public class Line
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public float Value { get; set; }
    public DateTime DateCreate { get; set; }
    public List<Machine> Machines { get; set; }

  }
}
