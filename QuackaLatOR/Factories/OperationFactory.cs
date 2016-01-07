using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;
using DependencyInjection;

namespace Factories
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
                foreach (Type t in Reflection.filteredTypes)
                {
                    if (s == t.GetField("text").GetValue(null).ToString())
                    {
                        var o = Activator.CreateInstance(t);
                        ICalculate i = (ICalculate)o;
                        operations.Add(i);
                    }
                }
            }
            operations.Sort(orderOfOperations);
            return operations;
        }
    }
}
