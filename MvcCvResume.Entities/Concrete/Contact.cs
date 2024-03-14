using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Contact : BaseModel
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Town { get; set; }
    public string City { get; set; }
}
