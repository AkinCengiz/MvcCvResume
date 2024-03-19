using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.SocialAccount;

public class SocialAccountList : ViewComponent
{
    private ISocialAccountService _socialAccountService;

    public SocialAccountList(ISocialAccountService socialAccountService)
    {
        _socialAccountService = socialAccountService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _socialAccountService.GetAll();
        return View(result);
    }
}
