using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISkillServiceBL
    {
        Skill GetByID(int id);
        void UpdateSkill(Skill skill);
    }
}
