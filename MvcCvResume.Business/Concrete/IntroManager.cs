using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class IntroManager : IIntroService
{
    private IIntroDal _introDal;

    public IntroManager(IIntroDal introDal)
    {
        _introDal = introDal;
    }

    public void Add(Intro intro)
    {
        _introDal.Add(intro);
    }

    public void Update(Intro intro)
    {
        _introDal.Update(intro);
    }

    public void Delete(Intro intro)
    {
        _introDal.Delete(intro);
    }

    public List<Intro> GetAll()
    {
        return _introDal.GetList();
    }

    public Intro Get(int id)
    {
        return _introDal.Get(i => i.Id == id);
    }
}
