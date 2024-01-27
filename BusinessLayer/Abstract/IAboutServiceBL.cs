using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutServiceBL
    {
        List<About> GetList();
        void AboutAdd(About about);
        About GetByID(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
