using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;
using Factories;

namespace Tests
{
    [TestClass]
    public class OperationFactoryTest
    {
        [TestMethod]
        public void orderTest()
        {
            OperationFactory operationFactory = new OperationFactory();
            List<string> equation = new List<string> { "5", "+", "7", "*", "2" };
            var result = operationFactory.createOperations(equation);
        }
    }
}
