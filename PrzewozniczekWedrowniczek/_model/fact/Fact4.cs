using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class Fact4 : IFact
    {
        public bool accept(bool[] elementalFormulas)
        {
            bool pre = !elementalFormulas[2] && !elementalFormulas[0];
            return pre ? elementalFormulas[5] : true;
        }
    }
}
