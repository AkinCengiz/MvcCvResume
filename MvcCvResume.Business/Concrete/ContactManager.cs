using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class ContactManager : IContactService
{
    private IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }


    public List<Contact> GetAll()
    {
        return _contactDal.GetList();
    }
}
