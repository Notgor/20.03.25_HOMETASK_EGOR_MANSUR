using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Team
    {
        
        private List<Employee> employees = new List<Employee>();

        public Employee this[int index]
        {
            get => employees[index];
            set => employees[index] = value;
        }

        public void AddEmployee(Employee employee) => employees.Add(employee);
    }
}
