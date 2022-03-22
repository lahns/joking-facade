using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public class System1
    {
        public string operation()
        {
            return "Wassup, dude!?\n";
        }
        public void crash()
        {
            throw new Exception("We hate you.");
        }

    }

}