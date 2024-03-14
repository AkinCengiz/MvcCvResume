using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Abstract;
public interface IAboutService
{
    void Add(About about);
    void Update(About about);
    void Delete(About about);
    List<About> GetAll();
    About GetById(int id);
}
