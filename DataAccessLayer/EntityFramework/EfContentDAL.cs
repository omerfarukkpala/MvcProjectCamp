using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //EfContentDAL
    public class EfContentDAL : GenericRepositoryDAL<Content>, IContentDAL
    {

    }
}
