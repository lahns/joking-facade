using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System1 subsystem1 = new System1();
            System2 subsystem2 = new System2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}