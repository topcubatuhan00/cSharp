using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MsSqlManager : IDB
    {
        public void Delete()
        {
            Console.WriteLine("deleted by mssql");
        }

        public void Save()
        {
            Console.WriteLine("saved by mssql");
        }
    }
}
