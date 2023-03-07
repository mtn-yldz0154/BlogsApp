using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var db = new Context();
            db.Add(entity);
        }

        public void Delete(T entity)
        {
            using var db = new Context();
            db.Remove(entity);
        }

        public List<T> GetAll()
        {
            using var db = new Context();
            
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var db = new Context();

            return db.Set<T>().Find(id);
        }

        public void UpdatE(T entity)
        {
            using var db = new Context();
            db.Update(entity);
        }
    }
}
