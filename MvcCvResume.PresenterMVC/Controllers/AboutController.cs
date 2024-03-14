using Microsoft.AspNetCore.Mvc;

namespace MvcCvResume.PresenterMVC.Controllers;
public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
