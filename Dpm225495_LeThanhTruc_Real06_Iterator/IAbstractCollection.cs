using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Real06_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
