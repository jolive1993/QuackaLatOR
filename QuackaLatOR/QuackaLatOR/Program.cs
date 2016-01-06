using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace QuackaLatOR
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler inputHandler = new InputHandler();
            inputHandler.getInput();
            inputHandler.splitInput();
            inputHandler.concateResult();
            foreach(string s in inputHandler.result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
