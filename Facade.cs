using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public class Facade
    {
        protected System1 _system1;

        protected System2 _system2;

        public Facade(System1 subsystem1, System2 subsystem2)
        {
            this._system1 = subsystem1;
            this._system2 = subsystem2;
        }
        
        public string Operation()
        {
            string result = "There's something important i have to say:\n";
            result += this._system1.operation();
            result += "But for real, I have to tell you this joke:\n";
            result += this._system2.Joke();
            result += "You will never know about mysterios crasher hidden behind the facade...\n";
            return result;
        }
    }
}
