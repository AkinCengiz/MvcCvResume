using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Blog;

public class BlogList : ViewComponent
{
    private readonly IBlogService _blogService;

    public BlogList(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _blogService.GetAll();
        return View(result);
    }
}
