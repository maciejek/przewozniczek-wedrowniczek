using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class Fact2 : IFact
    {
        public bool accept(bool[] elementalFormulas)
        {
            bool pre = elementalFormulas[1] && elementalFormulas[3] && !elementalFormulas[0];
            return pre ? elementalFormulas[4] : true;
        }
    }
}
