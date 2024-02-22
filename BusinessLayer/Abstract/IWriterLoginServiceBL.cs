using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //IWriterLoginServiceBL
    public interface IWriterLoginServiceBL
    {
        Writer GetWriter(string username, string password);
    }
}
