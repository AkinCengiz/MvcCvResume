using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using MvcCvResume.Business.Abstract;
using MvcCvResume.Business.Concrete;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.DataAccess.Concrete.EntityFramework;

namespace MvcCvResume.Business.Autofac;
public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<IntroManager>().As<IIntroService>();
        builder.RegisterType<EfIntroDal>().As<IIntroDal>();
        builder.RegisterType<AboutManager>().As<IAboutService>();
        builder.RegisterType<EfAboutDal>().As<IAboutDal>();
        builder.RegisterType<PersonalDetailManager>().As<IPersonalDetailService>();
        builder.RegisterType<EfPersonalDetailDal>().As<IPersonalDetailDal>();
        builder.RegisterType<EducationManager>().As<IEducationService>();
        builder.RegisterType<EfEducationDal>().As<IEducationDal>();
        builder.RegisterType<ExperienceManager>().As<IExperienceService>();
        builder.RegisterType<EfExperienceDal>().As<IExperienceDal>();
        builder.RegisterType<SkillManager>().As<ISkillService>();
        builder.RegisterType<EfSkillDal>().As<ISkillDal>();
        builder.RegisterType<PortfolioManager>().As<IPortfolioService>();
        builder.RegisterType<EfPortfolioDal>().As<IPortfolioDal>();
    }
}
