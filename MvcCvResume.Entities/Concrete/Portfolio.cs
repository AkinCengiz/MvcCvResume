using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Portfolio : BaseModel
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string UrlInfo { get; set; }
    public string Category { get; set; }
}
