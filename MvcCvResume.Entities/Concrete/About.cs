﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class About : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
}
