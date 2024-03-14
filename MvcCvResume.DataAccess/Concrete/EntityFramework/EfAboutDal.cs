using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.DataAccess.Concrete.EntityFramework.Contexts;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.DataAccess.Concrete.EntityFramework;
public class EfAboutDal : EfEntityRepositoryBase<About,MvcCvResumeContext>,IAboutDal
{
}
