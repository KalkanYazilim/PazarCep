using Microsoft.EntityFrameworkCore;
using pazarcep.dataaccess.Abstracts;
using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.dataaccess.Concretes.Repositories
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
               return context.Set<T>().ToList();
            }
        }

        public List<T> GetByFilter(Func<T, bool> filter)
        {
            using (var context = new TContext())
            {
               return context.Set<T>().Where(filter).ToList();
            }
        }

        public T Get(Func<T, bool> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
