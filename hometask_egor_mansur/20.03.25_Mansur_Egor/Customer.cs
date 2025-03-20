using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Customer
    {   
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
    
}
