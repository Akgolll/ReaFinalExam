using DataLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrate
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context db = new Context();
        DbSet<T> _obj;
        
        public GenericRepository()
        {
            _obj = db.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = db.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _obj.SingleOrDefault(filter);
        }

        public void Insert(T enitiy)
        {
            var insertedEntity = db.Entry(enitiy);
            insertedEntity.State = EntityState.Added;
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _obj.Where(filter).ToList();
        }

        public void Update(T enitiy)
        {
            var updatedEntity = db.Entry(enitiy);
            updatedEntity.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
