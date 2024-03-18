using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class SkillManager : ISkillService
{
    private ISkillDal _skillDal;

    public SkillManager(ISkillDal skillDal)
    {
        _skillDal = skillDal;
    }

    public List<Skill> GetSkillList()
    {
        return _skillDal.GetList();
    }

    public List<Skill> GetListByCategory(string category)
    {
        return _skillDal.GetList(s => s.Category == category);
    }
}
