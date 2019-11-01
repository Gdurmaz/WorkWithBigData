using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Helper
{
    public class Command<T>:TryCatchAction
    {
        public Connection.ConnectionDb _connDb = new Connection.ConnectionDb();
        public List<T> getEntites;
        public T _entites;
    }
}
