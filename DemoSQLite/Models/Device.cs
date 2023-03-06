using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Models
{
  public class Device
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public float Value { get; set; }
    public DateTime DateCreate { get; set; }

    public int? MachineId { get; set; }

    [Browsable(false)]
    public Machine? Machine { get; set; }

  }
}
