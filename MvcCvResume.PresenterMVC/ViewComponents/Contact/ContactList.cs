using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Contact;

public class ContactList : ViewComponent
{
    private IContactService _contactService;

    public ContactList(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _contactService.GetAll();
        return View(result);
    }
}
