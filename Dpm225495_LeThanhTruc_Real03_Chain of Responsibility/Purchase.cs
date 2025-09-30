using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpm225495_LeThanhTruc_Real03_Chain_of_Responsibility
{
    internal class Purchase
    {
        int number;
        double amount;
        string purpose;
        // Constructor
        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }
        // Gets or sets purchase number
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        // Gets or sets purchase amount
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        // Gets or sets purchase purpose
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}
