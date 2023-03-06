using DemoSQLite.Models;
using DemoSQLite.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLite.Repositorys
{
  public class RepositoryMachines
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(Machine machines)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      await _dbContext.Machines.AddAsync(machines);
      await _dbContext.SaveChangesAsync();
    }

    public void Delete(int id)
    {
      var machine = _dbContext.Machines.SingleOrDefault(m=> m.Id == id);

      _dbContext.Machines.Remove(machine);
      _dbContext.SaveChanges();
    }

    public List<Machine> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Machines.ToList();
    }

    public Machine? GetById(int id)
    {
      //var device = _dbContext.Machines.OrderByDescending(s => s.Id >=2).ToList();
      Machine? machineById = _dbContext.Machines.SingleOrDefault(s => s.Id == id);

      if (machineById != null)
      {
        return machineById;
      }
      else
      {
        return null;
      }
    }

    public List<int> GetIdMachine()
    {
      _dbContext.Database.EnsureCreated();
      var machine = _dbContext.Machines.Select(s => s.Id).ToList();

      return machine;
    }




    //var device = _dbContext.Devices.Select(d => new VDevices
    //{
    //  Name = d.Name,
    //  Value = d.Value,
    //  DateCreate = d.DateCreate,
    //  //MachineId = d.MachineId,
    //});

    //internal List<Machine> GetData(int ReAdd)
    //{
    //  _dbContext.Database.EnsureCreated();
    //  return _dbContext.Machines
    //          .Where(s => s.Id == ReAdd)
    //          .OrderByDescending(s => s.Id)
    //          .Take(10)
    //          .ToList();
    //}


    public void Update(Line machines)
    {
      throw new NotImplementedException();
    }
  }
}
