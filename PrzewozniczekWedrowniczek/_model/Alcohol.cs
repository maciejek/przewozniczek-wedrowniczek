using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek
{
    public class Alcohol
    {
        public static readonly Alcohol WINE = new Alcohol(0.3, 12);
        public static readonly Alcohol BEER = new Alcohol(0.5, 5.5);
        public static readonly Alcohol VODKA = new Alcohol(0.05, 40);

        private readonly double Alcohol_density = 0.79;
        private double sizeInMl;
        private double percent;

        private Alcohol(double sizeInL, double percent)
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
