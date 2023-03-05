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

    public async Task Add(Machine machines)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      await _dbContext.Machines.AddAsync(machines);
      await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Machine>> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return await _dbContext.Machines.ToListAsync();
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
