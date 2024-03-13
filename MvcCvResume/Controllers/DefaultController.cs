using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvResume.Models.Entities;

namespace MvcCvResume.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        PersonelBlogDbEntities dbEntities = new PersonelBlogDbEntities();
        public ActionResult Index()
        {
            var personalInfo = dbEntities.PersonalInformations;
            return View(personalInfo);
        }
    }
}