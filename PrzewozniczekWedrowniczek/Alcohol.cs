using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek
{
    public class Alcohol
    {
        private readonly double Alcohol_density = 0.79;
        private double sizeInMl;
        private double percent;

        public Alcohol(double sizeInL, double percent)
        {
            this.sizeInMl = sizeInL * 1000;
            this.percent = percent;
        }

        public double CalculateGramsOfAlcohol()
        {
            return sizeInMl * percent * Alcohol_density / 100;
        }
    }
}
