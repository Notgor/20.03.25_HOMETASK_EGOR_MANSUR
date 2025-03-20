using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class DateFormatter
    {
        public string FormatDate(int day = 1, int month = 1, int year = 2000)
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }
}
