using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Experience : BaseModel
{
    public string WorkingCompany { get; set; }
    public string Position { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
