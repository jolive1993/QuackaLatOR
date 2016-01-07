using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;

namespace Calculator
{
    public class Calculator
    {
        private List<string> equation;
        private List<Operations.ICalculate> operators;
        public Calculator(List<string> equation, List<Operations.ICalculate> operators)
        {
            this.equation = equation;
            this.operators = operators;
        }
        public int execute()
        {
            int index;
            int result;
            while (equation.Count > 1)
            {
                for (int i = 0; i < operators.Count; i++)
                {
                    index = equation.IndexOf(operators[i].Text);
                    try
                    {
                        operators[i].Num1 = Int32.Parse(equation[index - 1]);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        operators[i].Num1 = 0;
                    }
                    operators[i].Num2 = Int32.Parse(equation[index + 1]);
                    operators[i].calculate();
                    equation.RemoveAt(index + 1);
                    equation.RemoveAt(index);
                    try
                    {
                        equation.RemoveAt(index - 1);
                        equation.Insert(index - 1, operators[i].Result.ToString());
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        equation.Insert(index, operators[i].Result.ToString());
                    }
                }
            }
            result = Int32.Parse(equation[0]);
            return result;
        }
    }
}



