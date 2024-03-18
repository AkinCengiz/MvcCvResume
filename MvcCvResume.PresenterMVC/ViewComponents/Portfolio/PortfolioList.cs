using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Portfolio;

public class PortfolioList : ViewComponent
{
    private readonly IPortfolioService _portfolioService;

    public PortfolioList(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _portfolioService.GetAll();
        return View(result);
    }
}
