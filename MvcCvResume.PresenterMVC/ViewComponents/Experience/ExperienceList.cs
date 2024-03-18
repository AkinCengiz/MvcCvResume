using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Experience;

public class ExperienceList : ViewComponent
{
    private readonly IExperienceService _experienceService;

    public ExperienceList(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _experienceService.GetAll();
        return View(result);
    }
}
