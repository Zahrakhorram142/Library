using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class BorrowClass : IBaseEntity
{
    public BorrowClass()
    {
        CreationDate = DateTime.Now;
        IsActive = true;
    }
    public int BorrowID { get; set; }
    public string BorrowedBookName { get; set; }
    public DateTime BorrowingDate { get; set; }
    public DateTime ReturnDate { get; set; }
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
