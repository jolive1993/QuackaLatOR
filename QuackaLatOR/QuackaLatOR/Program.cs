using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Operations;
using DependencyInjection;
using Factories;

namespace QuackaLatOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            InputHandler inputHandler = new InputHandler();
            OperationFactory operationFactory = new OperationFactory();
            List<ICalculate> operaters;
            while (true)
            {
                inputHandler.getInput();
                inputHandler.splitInput();
                inputHandler.concateResult();
                operaters = operationFactory.createOperations(inputHandler.result);
                Calculator.Calculator calculator = new Calculator.Calculator(inputHandler.result, operaters);
                result = calculator.execute();
                Console.WriteLine(result);
                inputHandler.result.Clear();
                Console.ReadLine();
            }
        }
    }
}
