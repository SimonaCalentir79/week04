using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Interface_recap_
{
    public abstract class Human //nu poate fi instantiata, dar poate fi mostenita (asta ar fi si motivul existentei)
    {                           //poate contine proprietati si metode ce vor fi mostenite
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Human()//constructor
        {

        }
        public void MetodaInAbstracta(int param1)
        {

        }
    }
}
