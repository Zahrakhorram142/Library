using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Contract;

public interface IBaseEntity
{
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }
}
