using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Intro : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Profession { get; set; }
    public string Graduation { get; set; }
    public string ImageUrl { get; set; }
}
