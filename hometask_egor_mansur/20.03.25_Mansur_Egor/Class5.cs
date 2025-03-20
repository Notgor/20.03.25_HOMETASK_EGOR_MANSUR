using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Circle
    {
        public const double DEFAULT_RADIUS = 1.0;
        private readonly double pi = 3.14159;

        public double CalculateArea(double radius)
        {
            return pi * radius * radius;
        }
    }
}
