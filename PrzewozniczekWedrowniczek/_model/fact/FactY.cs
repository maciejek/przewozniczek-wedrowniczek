using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._model
{
    class FactY
    {
        public bool accept(bool[] elementalFormulas, bool[] yParams)
        {
            bool fastPre;
            if (yParams[0])
            {
                fastPre = (yParams[0] == elementalFormulas[4]);
            }
            else
            {
                fastPre = true;
            }

            bool safePre;
            if (yParams[1])
            {
                safePre = (yParams[1] == elementalFormulas[5]);
            }
            else
            {
                safePre = true;
            }
            return fastPre && safePre;

        }
    }
}
