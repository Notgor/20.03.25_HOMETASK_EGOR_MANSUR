using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Car
    {
        private string model;
        private int year;

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1886 || value > System.DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException(nameof(Year), "Неверный год.");
                year = value;
            }
        }
    }
}
