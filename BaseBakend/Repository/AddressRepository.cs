using BaseBakend.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class AddressRepository:BaseRepository
{
  public override bool Insert<Address>(Address address)
    {
        throw new NotImplementedException();
    }
    public override Address GetPeople<Address>()
    {
        throw new NotImplementedException();
    }
}
