using BaseBackend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class MemberClass :PersonClass
    {
        public int MembershipID { get; set; }
    }
}
