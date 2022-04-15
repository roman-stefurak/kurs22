using BookShop.Core.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookShop.Core.Services
{
    public abstract class BaseService<T> where T : class
    {
        protected internal readonly EnterpriseContext _context;

        public BaseService(EnterpriseContext context)
        {
            _context = context;
        }

        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToArray();
        }

        public ICollection<T> GetAll(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate)?.ToArray();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(T[] entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public T Find(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public T Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public bool Remove(long id)
        {
            var ent = Find(id);

            if (ent != null)
            {
                _context.Remove(ent);
                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}