using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class AboutManager : IAboutService
{
    private IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void Add(About about)
    {
        _aboutDal.Add(about);
    }

    public void Update(About about)
    {
        _aboutDal.Update(about);
    }

    public void Delete(About about)
    {
        _aboutDal.Delete(about);
    }

    public List<About> GetAll()
    {
        return _aboutDal.GetList();
    }

    public About GetById(int id)
    {
        return _aboutDal.Get(a => a.Id == id);
    }
}
