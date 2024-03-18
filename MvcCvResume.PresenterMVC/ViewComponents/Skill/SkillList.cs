using Microsoft.AspNetCore.Mvc;
using MvcCvResume.Business.Abstract;

namespace MvcCvResume.PresenterMVC.ViewComponents.Skill;

public class SkillList : ViewComponent
{
    private readonly ISkillService _skillService;

    public SkillList(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _skillService.GetSkillList();
        return View(result);
    }
}
