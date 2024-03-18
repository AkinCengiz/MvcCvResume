using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class PersonalDetailManager : IPersonalDetailService
{
    private IPersonalDetailDal _personalDetailDal;

    public PersonalDetailManager(IPersonalDetailDal personalDetailDal)
    {
        _personalDetailDal = personalDetailDal;
    }

    public List<PersonalDetail> GetAll()
    {
        return _personalDetailDal.GetList();
    }
}
