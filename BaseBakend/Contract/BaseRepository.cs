using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Contract;

public abstract class BaseRepository
{
    public abstract bool Insert<T>(T item);
    public abstract T GetPeople<T>();
}
