using DemoSQLite.Models;
using DemoSQLite.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Repositorys
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T option);
        void Update(T option);
        void Remove(int id);
         
    }
}
