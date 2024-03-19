using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class BlogManager : IBlogService
{
    private IBlogDal _blogDal;

    public BlogManager(IBlogDal blogDal)
    {
        _blogDal = blogDal;
    }

    public List<Blog> GetAll()
    {
        return _blogDal.GetList();
    }
}
