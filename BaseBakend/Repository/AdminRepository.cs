using BaseBakend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class AdminRepository : BaseRepository
{
    public override bool Insert<Admin>(Admin admin)
    {
        throw new NotImplementedException();
    }
    public override Admin GetPeople<Admin>()
    {
        throw new NotImplementedException();
    }
}

