using BusinessLayer.Abstract;
using DataLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TasksManager : IService<tasks>
    {
        GenericRepository<tasks> _task = new GenericRepository<tasks>();
        public void Add(tasks entity)
        {
            _task.Insert(entity);
        }

        public void Delete(tasks entity)
        {
            _task.Delete(entity);
        }

        public tasks GetById(int id)
        {
            return _task.Get(x=>x.Id == id);
        }

        public List<tasks> List()
        {
            return _task.List();
        }

        public List<tasks> List(Expression<Func<tasks, bool>> filter)
        {
            return _task.List();
        }

        public void Update(tasks entity)
        {
            _task.Update(entity);        
        }
    }
}
