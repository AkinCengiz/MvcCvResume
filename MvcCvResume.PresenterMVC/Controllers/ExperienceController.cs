using Microsoft.AspNetCore.Mvc;

namespace MvcCvResume.PresenterMVC.Controllers;
public class ExperienceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
