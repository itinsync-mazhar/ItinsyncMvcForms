using Itinsync.NonBusinessModel.Model.Icom.ItinsyncModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intinsync.DAL.ItinsyncDAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ItinsyncContext db = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this.db = new ItinsyncContext();
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
