using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Employee
    {
        private string name;
        private decimal salary;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Salary
        {
            get => salary;
            set
            {
                if (value < 0) throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }
    }
}
