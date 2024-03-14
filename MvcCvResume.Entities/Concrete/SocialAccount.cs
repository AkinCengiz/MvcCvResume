using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class SocialAccount : BaseModel
{
    public string Name { get; set; }
    public string platformUrl { get; set; }
    public string AccountName { get; set; }
    public string Icon { get; set; }

}
