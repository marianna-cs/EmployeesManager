using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using EmployeesManager.Models;

namespace EmployeesManager.Repository
{
    public abstract class Repository<T> where T : class, IEntity
    {
        protected DatabaseContext _context;
        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAllList()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {            
            return _context.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Entry(entity).State = EntityState.Deleted;
            //_context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
