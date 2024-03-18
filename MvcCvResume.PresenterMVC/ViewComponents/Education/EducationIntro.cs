using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Education;

public class EducationIntro : ViewComponent
{
    private IEducationService _educationService;

    public EducationIntro(IEducationService educationService)
    {
        _educationService = educationService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _educationService.GetAll();
        return View(result);
    }
}
