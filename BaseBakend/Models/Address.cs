using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class Address : IBaseEntity
{
    public Address()
    {
        CreationDate = DateTime.Now;
        IsActive = true;
    }
    public int ID { get; set; }
    public string Title { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string FullAddress { get; set; }
    public string PostalCode { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }

    public string PersianCreationDate
    {
        get
        {
            string persianD = CreationDate.ToString("yyyy,mm,dd", new CultureInfo("fa-IR"));
            return persianD;
        }
    }
}
