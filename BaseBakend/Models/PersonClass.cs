using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public partial class PersonClass : IBaseEntity
    {
        public PersonClass()
        {
            CreationDate = DateTime.Now;
            IsActive = true;
        }
        public int PersonID { get; set; }
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public string persianCreationDate
        {
            get
            {
                string persianD = CreationDate.ToString("yyyy,mm,dd", new CultureInfo("fa-IR"));
                return persianD;
            }
        }
    }
}
