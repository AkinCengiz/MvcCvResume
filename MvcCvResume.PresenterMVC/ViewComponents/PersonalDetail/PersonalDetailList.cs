using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.PersonalDetail;

public class PersonalDetailList : ViewComponent
{
    private IPersonalDetailService _personalDetailService;

    public PersonalDetailList(IPersonalDetailService personalDetailService)
    {
        _personalDetailService = personalDetailService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _personalDetailService.GetAll();
        return View(result);
    }
}
