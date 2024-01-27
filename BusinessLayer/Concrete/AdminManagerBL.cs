using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManagerBL
    {
        IAdminDAL _adminDal;

        public AdminManagerBL(IAdminDAL adminDal)
        {
            _adminDal = adminDal;

        }

        public Admin GetAdminRole(string username)
        {
            return _adminDal.Get(x => x.AdminUserName == username);
        }

        public Admin GetAdmin(string username, string password)
        {
            return _adminDal.Get(x => x.AdminUserName == username && x.AdminPassword == password);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }

        public void AdminAdd(Admin p)
        {
            _adminDal.Insert(p);
        }

        public Admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminID == id);
        }

        public void AdminDelete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
