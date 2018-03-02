using Intinsync.DAL;
using Intinsync.DAL.ItinsyncDAL;
using Itinsync.NonBusinessModel.Model.Icom.ItinsyncModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intinsync.BLL
{
    public class UserAccountBLL
    {
        private IGenericRepository<UserAccount> repository = null;
        public UserAccountBLL()
        {
            repository = new GenericRepository<UserAccount>();
        }
        public IEnumerable<UserAccount> SelectAll()
        {
            return repository.SelectAll();
        }

        public UserAccount SelectById(string id)
        {
            return repository.SelectById(id);
        }

        public void Insert(UserAccount objUser)
        {
            repository.Insert(objUser);
        }

        public void Update(UserAccount objUser)
        {
            repository.Update(objUser);
        }

        public void Delete(string id)
        {
            repository.Delete(id);
        }

        public void Save()
        {
            repository.Save();
        }
    }
}
