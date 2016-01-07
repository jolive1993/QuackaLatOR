using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Exponent : ICalculate
    {
        public static string text = "^";
        public int Priority { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public string Text { get; set; }

        public Exponent()
        {
            Priority = 0;
            Text = text;
        }
        public void calculate()
        {
            Result = Convert.ToInt32(Math.Pow(Convert.ToDouble(Num1), Convert.ToDouble(Num2)));
        }
    }

}
