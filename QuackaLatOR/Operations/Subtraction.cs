using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection;

namespace Operations
{
    public class Subtraction : ICalculate
    {
        public static string text = "-";
        public int Priority { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public string Text { get; set; }

        public Subtraction()
        {
            Priority = 2;
            Text = text;
        }
        public void calculate()
        {
            Result = Num1 - Num2;
        }
    }

}
