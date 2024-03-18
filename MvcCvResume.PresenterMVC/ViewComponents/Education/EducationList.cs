using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Education;

public class EducationList : ViewComponent
{
    private IEducationService _educationService;

    public EducationList(IEducationService educationService)
    {
        _educationService = educationService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _educationService.GetAll();
        return View(result);
    }
}
