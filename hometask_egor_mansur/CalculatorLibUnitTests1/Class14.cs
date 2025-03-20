using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal CalculateTotal() => Items.Sum(item => item.Price);
    }    
}
