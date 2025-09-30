using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Pattern05_Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
