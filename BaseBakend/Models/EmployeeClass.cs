using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class EmployeeClass : PersonClass
{
    public EmployeeClass()
    {
        CreationDate = DateTime.Now;
        IsActive = true;

    }
    public int EmployeeID { get; set; }
    public string NationalCode { get; set; }
    public string JobTitle { get; set; }
    public DateTime EmployeementDate { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsActive { get; set; }
    public string PersianCreationDate
    {
        get
        {
            string persianD = CreationDate.ToString("yyyy,mm,dd", new CultureInfo("fa-IR"));
            return persianD;
        }
    }

}
