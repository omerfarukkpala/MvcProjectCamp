using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentServiceBL
    {
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
        void ContentAdd(Content content);
        Content GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
