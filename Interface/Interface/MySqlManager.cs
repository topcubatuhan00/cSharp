﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MySqlManager : IDB
    {
        public void Delete()
        {
            Console.WriteLine("deleted by mysql");
        }

        public void Save()
        {
            Console.WriteLine("saved by mysql");
        }
    }
}
