﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.Business.Abstract;
public interface ISkillService
{
    List<Skill> GetSkillList();
    List<Skill> GetListByCategory(string category);
}
