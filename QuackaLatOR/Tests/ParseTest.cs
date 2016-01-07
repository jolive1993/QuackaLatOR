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
    public class ParseTest
    {
        [TestMethod]
        public void parseNegativeTest()
        {
            List<string> expected;
            InputHandler inputHandler = new InputHandler();
            inputHandler.input = "-7 + 4";
            expected = new List<string> { "-7", "+", "4" };
            inputHandler.splitInput();
            inputHandler.concateResult();
            var actual = inputHandler.result;
            Assert.AreEqual(expected, actual, "Don't work");
        }
        [TestMethod]
        public void parseExtraneousWhiteSpaceTest()
        {
            List<string> expected;
            InputHandler inputHandler = new InputHandler();
            inputHandler.input = "7   +   4";
            expected = new List<string> { "7", "+", "4" };
            inputHandler.splitInput();
            inputHandler.concateResult();
            var actual = inputHandler.result;
            Assert.AreEqual(expected, actual, "Don't work");
        }
        [TestMethod]
        public void parseUnexpectedInput()
        {
            List<string> expected;
            InputHandler inputHandler = new InputHandler();
            inputHandler.input = "7+yolo-4";
            expected = new List<string> { "7", "+", "yolo", "-", "4" };
            inputHandler.splitInput();
            inputHandler.concateResult();
            var actual = inputHandler.result;
            Assert.AreEqual(expected, actual, "Don't work");
        }
    }
}
