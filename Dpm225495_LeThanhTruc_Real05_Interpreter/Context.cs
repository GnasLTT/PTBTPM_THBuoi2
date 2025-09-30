using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Real05_Interpreter
{
    public class Context
    {
        string input;
        int output;
        // Constructor
        public Context(string input)
        {
            this.input = input;
        }
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
