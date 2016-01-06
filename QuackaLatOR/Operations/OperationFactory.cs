using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class OperationFactory
    {
        private char[] acceptedOperators = Constants.acceptedoperators;
        public List<ICalculate> operations;
        public List<string> operators;
        private int orderOfOperations(ICalculate x, ICalculate y)
        {
            if (x.Priority < y.Priority)
            {
                return -1;
            }
            else if (x.Priority == y.Priority)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public List<ICalculate> createOperations(List<string> equation)
        {
            operations = new List<ICalculate>();
            operators = equation.FindAll(Constants.findOperators);
            foreach (string s in operators)
            {
                if (s[0] == acceptedOperators[0])
                {
                    var o = new Multiplication();
                    operations.Add(o);
                }
                else if (s[0] == acceptedOperators[1])
                {
                    var o = new Division();
                    operations.Add(o);
                }
                else if (s[0] == acceptedOperators[2])
                {
                    var o = new Addition();
                    operations.Add(o);
                }
                else if (s[0] == acceptedOperators[3])
                {
                    var o = new Subtraction();
                    operations.Add(o);

                }
            }
            operations.Sort(orderOfOperations);
            return operations;
        }
    }
}

