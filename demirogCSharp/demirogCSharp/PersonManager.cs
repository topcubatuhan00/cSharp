using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demirogCSharp
{
    class PersonManager
    {
        public void add(IPerson person)
        {
            Console.WriteLine(person.name+" added");
        }

      
    }
}
