using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    public partial class Product
    {
        public decimal GetDiscountedPrice(decimal discount) => Price - (Price * discount / 100);
    }
}
