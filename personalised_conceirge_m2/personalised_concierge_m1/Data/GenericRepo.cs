using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Data
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ConciergeContext _context;
        public GenericRepo(ConciergeContext context)
        {
            this._context = context;
        }
        
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}