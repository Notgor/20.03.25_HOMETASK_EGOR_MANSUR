using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Statistics
    {
        public (int Min, int Max, double Average) Analyze(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();
            return (min, max, avg);
        }
    }
}
