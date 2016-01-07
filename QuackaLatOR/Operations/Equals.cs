using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Equals : ICalculate
    {
        public static string text = "=";
        public int Priority { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public string Text { get; set; }

        public Equals()
        {
            Priority = 3;
            Text = text;
        }
        public void calculate()
        {
            if (Num1 == Num2)
            {
                Result = 1;
            }
            else
            {
                Result = 0;
            }
        }
    }

}
