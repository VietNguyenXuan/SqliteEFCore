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
  public class RepositoryLines
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(Line lines)
    {
      await _dbContext.Database.EnsureCreatedAsync();
      await _dbContext.Lines.AddAsync(lines);
      await _dbContext.SaveChangesAsync();
    }

    public void Delete(int id)
    {
      var line = _dbContext.Lines.SingleOrDefault(m => m.Id == id);

      _dbContext.Lines.Remove(line);
      _dbContext.SaveChanges();
    }

    public List<Line> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Lines.ToList();
    }

    public Line GetById(int id)
    {
      throw new NotImplementedException();
    }

    public List<int> GetIdLine()
    {
      _dbContext.Database.EnsureCreated();
      var machine = _dbContext.Lines.Select(s => s.Id).ToList();

      return machine;
    }

    public void Update(Line machines)
    {
      throw new NotImplementedException();
    }
  }
}
