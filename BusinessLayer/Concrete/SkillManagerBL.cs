using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManagerBL : ISkillServiceBL
    {
        ISkillDAL _skillDal;

        public SkillManagerBL(ISkillDAL skillDal)
        {
            _skillDal = skillDal;
        }

        public Skill GetByID(int id)
        {
            return _skillDal.Get(x => x.SkillID == id);
        }

        public void UpdateSkill(Skill skill)
        {
            _skillDal.Update(skill);
        }
    }
}
