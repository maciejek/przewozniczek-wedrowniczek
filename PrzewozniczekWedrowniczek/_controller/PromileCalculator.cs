using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek
{
    public class PromileCalculator
    {
        private readonly double K_factor;
        private const double BurningFactor = 5;

        public PromileCalculator(Sex sex)
        {
            if (sex==Sex.WOMAN) K_factor = 0.6;
            else K_factor = 0.7;
        }

        public double CalculatePromiles(List<Alcohol> alcohol, double weight, double hours)
        {
            double promiles = 0.0;
            foreach (Alcohol alco in alcohol)
            {
                promiles += alco.CalculateGramsOfAlcohol();
            }

            promiles -= (hours * BurningFactor);
            promiles /= (weight * K_factor);
            return promiles;
        }
    }
}
