using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class ExperienceManager : IExperienceService
{
    private IExperienceDal _experienceDal;

    public ExperienceManager(IExperienceDal experienceDal)
    {
        _experienceDal = experienceDal;
    }

    public List<Experience> GetAll()
    {
        return _experienceDal.GetList();
    }
}
