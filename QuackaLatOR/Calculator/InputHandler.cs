using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private char[] acceptedoperators = { '*', '/', '+', '-' };
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
        }
        public void splitInput()
        {
            numbers = input.Split(acceptedoperators, StringSplitOptions.RemoveEmptyEntries);
            operators = input.ToArray();
            foreach (char c in operators)
            {
                if (c == acceptedoperators[0] | c == acceptedoperators[1] | c == acceptedoperators[2] | c == acceptedoperators[3])
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
    }
}
