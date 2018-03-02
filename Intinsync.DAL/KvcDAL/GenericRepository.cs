using Itinsync.BusinessModel.Model.Icom.CustomerModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intinsync.DAL.KvcDAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private kvcContext db = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this.db = new kvcContext();
            table = db.Set<T>();
        }

        public GenericRepository(kvcContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }

        public T SelectById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T obj = table.Find(id);
            table.Remove(obj);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
