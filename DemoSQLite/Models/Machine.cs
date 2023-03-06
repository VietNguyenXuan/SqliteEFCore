using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Models
{
  public class Machine
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreate { get; set; }

    public int? LineId { get; set; }
    public Line? Line { get; set; }

    [Browsable(false)]
    public List<Device> Devices { get; set; }


  }
}
