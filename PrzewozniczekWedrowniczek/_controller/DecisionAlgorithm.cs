using PrzewozniczekWedrowniczek._model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek._controller
{
    class DecisionAlgorithm
    {
        private FactController factController;

        public DecisionAlgorithm()
        {
            factController = new FactController();
        }

        public List<Result> makeDecision(bool[] data)
        {
            bool alfay1 = data[3];
            bool alfay2 = data[4];
            bool a,b,c,d,e,f;

            HashSet<Result> u1 = new HashSet<Result>();
            HashSet<Result> u2 = new HashSet<Result>();
            
            a = false;
            do 
            {
                b = false;

                do 
                {
                    c = false;

                    do 
                    {
                        d = false;

                        do 
                        {
                             e = false;

                            do 
                            {
                                f = false;

                                do 
                                {

                                    bool[] alphas = { a, b, c, d, e, f };
                                    if ( factController.evaluateWFact(alphas, data) && factController.evaluate(alphas) )
                                    {
                                        FactY factY = new FactY();
                                        bool[] alfays = {alfay1, alfay2};
                                        if ( factY.accept(alphas,  alfays) )
                                        {
                                            u1.Add( d ? Result.WALK : Result.BUS);
                                        }
                                        else
                                        {
                                            u2.Add(d ? Result.WALK : Result.BUS);
                                        }
                                    }

                                    f = !f;
                                } while (f);
                                e = !e;
                            } while (e);
                            d = !d;
                        }while (d);
                        c = !c;
                    }while (c);
                    b = !b;
                }while (b);
                a = !a;
            }while (a);

            List<Result> result = u1.Except(u2).ToList();
            if (result.Count() == 0)
            {
                result.Add(Result.UNKNOWN);
            }

            return result;

        }
    }
}
