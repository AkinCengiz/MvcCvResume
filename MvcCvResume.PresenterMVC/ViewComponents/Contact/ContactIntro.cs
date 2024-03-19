using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Contact;

public class ContactIntro : ViewComponent
{
    private readonly IContactService _contactService;

    public ContactIntro(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _contactService.GetAll();
        return View(result);
    }
}
