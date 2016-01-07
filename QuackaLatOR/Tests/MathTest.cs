using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;
namespace Tests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void additionTest()
        {
            List<ICalculate> operaters;
            List<string> equation;
            int expected;
            Addition plus = new Addition();
            operaters = new List<ICalculate> { plus };
            equation = new List<string> { "4", "+", "3" };
            Calculator.Calculator calculator = new Calculator.Calculator(equation, operaters);
            var actual = calculator.execute();
            expected = 7;
            Assert.AreEqual(expected, actual, "Don't Work");
        }
        [TestMethod]
        public void subtractionTest()
        {
            List<ICalculate> operaters;
            List<string> equation;
            int expected;
            Subtraction minus = new Subtraction();
            operaters = new List<ICalculate> { minus };
            equation = new List<string> { "4", "-", "3" };
            Calculator.Calculator calculator = new Calculator.Calculator(equation, operaters);
            var actual = calculator.execute();
            expected = 1;
            Assert.AreEqual(expected, actual, "Don't Work");
        }
        [TestMethod]
        public void multiplicationTest()
        {
            List<ICalculate> operaters;
            List<string> equation;
            int expected;
            Multiplication multiplication = new Multiplication();
            operaters = new List<ICalculate> { multiplication };
            equation = new List<string> { "4", "*", "3" };
            Calculator.Calculator calculator = new Calculator.Calculator(equation, operaters);
            var actual = calculator.execute();
            expected = 12;
            Assert.AreEqual(expected, actual, "Don't Work");
        }
        [TestMethod]
        public void divisionTest()
        {
            List<ICalculate> operaters;
            List<string> equation;
            int expected;
            Division division = new Division();
            operaters = new List<ICalculate> { division };
            equation = new List<string> { "6", "/", "2" };
            Calculator.Calculator calculator = new Calculator.Calculator(equation, operaters);
            var actual = calculator.execute();
            expected = 3;
            Assert.AreEqual(expected, actual, "Don't Work");
        }
    }
}
