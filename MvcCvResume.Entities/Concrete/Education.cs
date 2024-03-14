using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;
public class Education : BaseModel
{
    public string SchoolName { get; set; }
    public string Degree { get; set; }
    public string MainPart { get; set; }
    public string Part { get; set; }
    public decimal GPA { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
