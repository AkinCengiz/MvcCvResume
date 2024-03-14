using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Abstract;
public interface IIntroService
{
    void Add(Intro intro);
    void Update(Intro intro);
    void Delete(Intro intro);
    List<Intro> GetAll();
    Intro Get(int id);
}
