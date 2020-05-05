using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    interface IHeapFun
    {
        int ExtractMin();
        int DecreaseKey(int elementIndex, int newValue);
        int Delete(int elementIndex);
        int Add(int newValue);
    }
}
