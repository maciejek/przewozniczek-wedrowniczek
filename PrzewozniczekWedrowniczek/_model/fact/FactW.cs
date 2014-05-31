using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class FactW
    {
        public bool accept(bool elementalFormula, bool param)
        {
            return param == elementalFormula;
        }
    }
}
