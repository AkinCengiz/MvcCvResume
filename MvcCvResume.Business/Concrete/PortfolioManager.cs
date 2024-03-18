using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Business.Abstract;
using MvcCvResume.DataAccess.Abstract;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Concrete;
public class PortfolioManager : IPortfolioService
{
    private IPortfolioDal _portfolioDal;

    public PortfolioManager(IPortfolioDal portfolioDal)
    {
        _portfolioDal = portfolioDal;
    }

    public List<Portfolio> GetAll()
    {
        return _portfolioDal.GetList();
    }
}
