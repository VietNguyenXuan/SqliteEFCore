using DemoSQLite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Controls
{
  public class ControllersDbDevice
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public void AddData(Device device)
    {
      _dbContext.Database.EnsureCreated();
      _dbContext.Devices.Add(device);
      _dbContext.SaveChanges();
    }

    public List<Device> GetAllData()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Devices.ToList();
    }
  }
}
