using BaseBakend.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class MemberRepository:BaseRepository
{
    public override bool Insert<Member>(Member member)
    {
        throw new NotImplementedException();
    }
    public override Member GetPeople<Member>()
    {
        throw new NotImplementedException();
    }
}
