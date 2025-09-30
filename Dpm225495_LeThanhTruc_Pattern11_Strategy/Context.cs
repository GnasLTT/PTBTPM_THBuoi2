using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Pattern11_Strategy
{
    internal class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
