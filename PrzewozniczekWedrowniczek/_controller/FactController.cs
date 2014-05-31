using PrzewozniczekWedrowniczek._model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._controller
{
    class FactController
    {
        public bool evaluate(bool[] alphas)
        {
            List<IFact> facts = new List<IFact> { new Fact1(), new Fact2(), new Fact3(), new Fact4() };

            foreach (IFact fact in facts)
            {
                if ( !fact.accept(alphas) )
                {
                    return false;
                }
            }

            return true;
        }

        public bool evaluateWFact(bool[] alphas, bool[] data)
        {
            bool isDrunk = data[0];
            bool isFasterWalking = data[1];
            bool isWoman = data[2];
            bool alfay1 = data[3];
            bool alfay2 = data[4];

            FactW factW = new FactW();
            return factW.accept(isDrunk, alphas[0]) && factW.accept(isFasterWalking, alphas[1]) && factW.accept(isWoman, alphas[2])
                && factW.accept(alfay1, alphas[3]) && factW.accept(alfay2, alphas[4]);
        }
    }


}
