using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Pattern05_Interpreter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();
            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
