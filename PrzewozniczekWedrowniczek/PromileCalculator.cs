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

        public PromileCalculator(bool isWoman)
        {
            if (isWoman) K_factor = 0.6;
            else K_factor = 0.7;
        }

        public double CalculatePromiles(Alcohol alcohol, double weight, double hours)
        {
            Console.WriteLine(weight);
            Console.WriteLine(K_factor);
            Console.WriteLine(alcohol.CalculateGramsOfAlcohol());
            return (alcohol.CalculateGramsOfAlcohol() - hours * BurningFactor) / (weight * K_factor);
        }
    }
}
