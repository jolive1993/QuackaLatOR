using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;
using DependencyInjection;

namespace Calculator
{
    public class InputHandler
    {
        public string input;
        public string[] numbers;
        public char[] operators;
        public Stack<string> operatorStack;
        public Stack<string> numberStack;
        public List<string> result;
        private char[] numberChars = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public InputHandler()
        {
            numberStack = new Stack<string>();
            operatorStack = new Stack<string>();
            result = new List<string>();
        }
        public void getInput()
        {
            Console.WriteLine("Enter a calculation");
            input = Console.ReadLine();
            foreach (char c in input)
            {
                if (!Reflection.getOperators().Contains(c))
                {
                    if (!numberChars.Contains(c))
                    {
                        Console.Beep(2000, 1000);
                        Console.WriteLine("Not accepted format, try again");
                        getInput();
                    }
                }
            }
        }
        public void splitInput()
        {
            numbers = input.Split(Constants.acceptedoperators, StringSplitOptions.RemoveEmptyEntries);
            operators = input.ToArray();
            foreach (char c in operators)
            {
                if (Constants.acceptedoperators.Contains(c))
                {
                    operatorStack.Push(c.ToString());
                }
            }
            foreach (string s in numbers)
            {
                numberStack.Push(s);
            }

        }
        public void concateResult()
        {
            while (numberStack.Count > 0)
            {
                result.Add(numberStack.Pop());
                if (operatorStack.Count != 0)
                {
                    result.Add(operatorStack.Pop());
                }
            }
            result.Reverse();
        }
        public void execute()
        {
            getInput();
            splitInput();
            concateResult();
        }
    }
}
