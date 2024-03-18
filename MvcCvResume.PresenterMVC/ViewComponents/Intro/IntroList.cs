using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Intro;

public class IntroList : ViewComponent
{
    private IIntroService _introService;

    public IntroList(IIntroService introService)
    {
        _introService = introService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _introService.GetAll();
        return View(result);
    }
}
