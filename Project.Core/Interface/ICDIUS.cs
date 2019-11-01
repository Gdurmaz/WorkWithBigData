using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Interface
{
    public interface ICDIUS<T> where T:class,new()
    {
        int Control(T t);
        int Delete(T t);
        int Insert(T t);
        int Update(T t);
        List<T> Select();
        T Find(int ID);
        T Find(Guid ID);
    }
}
