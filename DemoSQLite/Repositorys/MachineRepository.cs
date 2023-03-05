using DemoSQLite.Models;
using DemoSQLite.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Repositorys
{
  public interface MachineRepository
  {
    List<ViewMachine> GetAll();
    ViewMachine GetById(int id);
    ViewMachine Add(Machine machines);
    void Update(ViewMachine machines);
    void Delete(int id);
  }}
