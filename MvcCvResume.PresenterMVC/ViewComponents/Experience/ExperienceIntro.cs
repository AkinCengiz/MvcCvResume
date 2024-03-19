using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Experience;

public class ExperienceIntro : ViewComponent
{
    private IExperienceService _experienceService;

    public ExperienceIntro(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _experienceService.GetAll();
        return View(result);
    }
}
