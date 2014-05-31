using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class Fact3 : IFact
    {
        public bool accept(bool[] elementalFormulas)
        {
            bool pre = elementalFormulas[0] && !elementalFormulas[3]; 
            return pre ? (elementalFormulas[4] && elementalFormulas[5]) : true;
        }
    }
}
