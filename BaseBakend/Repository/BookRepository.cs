using BaseBakend.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class BookRepository : BaseRepository
{
    public override bool Insert<Book>(Book book)
    {
        throw new NotImplementedException();
    }
    public override Book GetPeople<Book>()
    {
        throw new NotImplementedException();
    }
}

    
