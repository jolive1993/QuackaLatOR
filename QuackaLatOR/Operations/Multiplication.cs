using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Multiplication : ICalculate
    {
        public int Priority { get; set; }
        public string Text { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public Multiplication()
        {
            Priority = 1;
            Text = "*";
        }
        public void calculate()
        {
            Result = Num1 * Num2;
        }
    }

}