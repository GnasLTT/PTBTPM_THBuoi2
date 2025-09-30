using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Pattern11_Strategy
{
    internal class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
