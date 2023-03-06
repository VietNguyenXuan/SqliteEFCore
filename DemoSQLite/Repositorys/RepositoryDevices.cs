using DemoSQLite.Models;
using DemoSQLite.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Repositorys
{
  public class RepositoryDevices
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(Device devices)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      await _dbContext.Devices.AddAsync(devices);
      await _dbContext.SaveChangesAsync();
    }

    public void Delete(int id)
    {
      var device = _dbContext.Devices.SingleOrDefault(m => m.Id == id);

      _dbContext.Devices.Remove(device);
      _dbContext.SaveChanges();
    }

    //public List<VDevices> GetAll()
    //{
    //  var device = _dbContext.Devices.Select(d => new VDevices
    //  {
    //    Name = d.Name,
    //    Value = d.Value,
    //    DateCreate = d.DateCreate,
    //    //MachineId = d.MachineId,
    //  });

    //  return  device.ToList();
    //}

    public List<Device> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Devices.ToList();
    }

    public Device? GetById(int id)
    {
      var device = _dbContext.Devices.Where(s => s.Id == 1).FirstOrDefault<Device>();

      //var devide1 = _dbContext.Devices.Where(d => d.Id == id);

      if (device != null)
      {
        return device;
      }
      else
      {
        return null;
      }

    }

    public List<int> GetIdDevice()
    {
      _dbContext.Database.EnsureCreated();
      var machine = _dbContext.Devices.Select(s => s.Id).ToList();

      return machine;
    }

    public void Update(Line machines)
    {
      //var devide = _dbContext.Devices.SingleOrDefault
    }
  }
}
