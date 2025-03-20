using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Counter
    {
        private static int instanceCount = 0;

        public Counter()
        {
            instanceCount++;
        }

        public static int GetInstanceCount() => instanceCount;
    }
}
