using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class Fact1 : IFact
    {
        public bool accept(bool[] elementalFormulas)
        {
            bool pre = !elementalFormulas[3] && (elementalFormulas[0] || elementalFormulas[2]);
            return pre ? elementalFormulas[5] : true;
        }
    }
}
