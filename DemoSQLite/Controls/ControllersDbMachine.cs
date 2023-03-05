using DemoSQLite.Models;
using DemoSQLite.Repositorys;
using DemoSQLite.Views;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Controls
{
  public class ControllersDbMachine
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public void Add(Machine machines)
    {
      _dbContext.Database.EnsureCreated();
      _dbContext.Machines.Add(machines);
      _dbContext.SaveChanges();
    }

    public List<Machine> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Machines.ToList();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

   
    public ViewMachine GetById(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(ViewMachine machines)
    {
      throw new NotImplementedException();
    }
    
  }
}
