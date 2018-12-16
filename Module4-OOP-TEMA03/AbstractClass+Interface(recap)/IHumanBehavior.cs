using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Interface_recap_
{
    interface IHumanBehavior//defineste metode dar doar ca nume si parametri
    {                       //poate fi initializata si mostenita
        void Walk(string direction);
    }
}
