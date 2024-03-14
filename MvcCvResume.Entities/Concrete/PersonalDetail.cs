using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MvcCvResume.Entities.Concrete;

public class PersonalDetail : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string DrivingLicence { get; set; }
    public string BloodGroup { get; set; }
    public string Phone { get; set; }
    public string MartialStatus { get; set; }
    public string Nationality { get; set; }
    public string BirthPlace { get; set; }
    public string NationalIdentity { get; set; }
}