using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Blog : BaseModel
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string BlogUrl { get; set; }
    public string ImageUrl { get; set; }

}
