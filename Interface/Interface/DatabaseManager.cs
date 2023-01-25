using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class DatabaseManager
    {
        public void Save(IDB dB)
        {
            dB.Save();
        }
        public void Delete(IDB dB)
        {
            dB.Delete();
        }
    }
}
