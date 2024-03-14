using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.Controllers;
public class DefaultController : Controller
{
    private IIntroService _introService;

    public DefaultController(IIntroService introService)
    {
        _introService = introService;
    }


    public IActionResult Index()
    {
        var intro = _introService.GetAll();
        return View(intro);
    }

    public PartialViewResult AboutPartial()
    {
        return PartialView();
    }
