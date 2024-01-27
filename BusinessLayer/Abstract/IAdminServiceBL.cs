using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminServiceBL
    {
        Admin GetAdmin(string username, string password);
        Admin GetAdminRole(string username);
        List<Admin> GetList();
        void AdminAdd(Admin add);
        Admin GetByID(int id);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
    }
}
