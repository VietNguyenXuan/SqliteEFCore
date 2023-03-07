using DemoSQLite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoSQLite.Repositorys
{
    
    internal class BaseRepositor<T> : IRepository<T>  where T : class
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
  
        public T Add(T option)
        {
           
            _dbContext.Database.EnsureCreated();
            _dbContext.Set<T>().Add(option);
             
            _dbContext.SaveChanges();
            return option;
            
        }

        

       
        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
            
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
    
}
