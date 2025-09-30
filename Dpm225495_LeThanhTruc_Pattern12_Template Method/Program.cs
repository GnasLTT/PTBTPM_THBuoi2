using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Pattern12_Template_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
    }
}
