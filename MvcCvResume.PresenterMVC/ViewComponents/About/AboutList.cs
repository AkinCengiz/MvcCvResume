using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.About;

public class AboutList : ViewComponent
{
    private IAboutService _aboutService;

    public AboutList(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _aboutService.GetAll();
        return View(result);
    }
}
