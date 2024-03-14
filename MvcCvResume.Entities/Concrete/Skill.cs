using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Skill : BaseModel
{
    public string Name { get; set; }
    public int Rate { get; set; }
    public string Icon { get; set; }
    public string Category { get; set; }
}
