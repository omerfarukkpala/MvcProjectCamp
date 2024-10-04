using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic; 
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepositoryDAL<T> : IRepositoryDAL<T> where T : class
    {
        Context db = new Context(); // sql bağlantı
        DbSet<T> _object; // obje tanımladık

        public GenericRepositoryDAL() // değer atamak için
        {
            _object = db.Set<T>();
        }
        public void Delete(T t)
        {
            var deletedEntity = db.Entry(t); // 1. yol
            deletedEntity.State = EntityState.Deleted;

          //  _object.Remove(t); 2. yol
            db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T t)
        {
            var addedEntity = db.Entry(t); // 1. yol
            addedEntity.State = EntityState.Added;

           // _object.Add(t); 2. yol
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var updatedEntity = db.Entry(t); // 1. yol
            updatedEntity.State = EntityState.Modified;
            
            db.SaveChanges(); // 2. yol
        }
    }
}
