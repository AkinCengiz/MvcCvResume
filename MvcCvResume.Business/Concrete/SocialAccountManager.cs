using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class SocialAccountManager : ISocialAccountService
{
    private ISocialAccountDal _socialAccountDal;

    public SocialAccountManager(ISocialAccountDal socialAccountDal)
    {
        _socialAccountDal = socialAccountDal;
    }

    public List<SocialAccount> GetAll()
    {
        return _socialAccountDal.GetList();
    }
}
