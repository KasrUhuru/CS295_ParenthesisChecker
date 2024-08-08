using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParenthesisChecker;

namespace ParenthesisChecker.Tests
{
    [TestClass()]
    public class ParenthesisCheckerTests
    {
        [TestMethod]
        public void TestSingleTypeBrackets()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("()"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("[]"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("{}"));
        }

        [TestMethod]
        public void TestMixedTypeBrackets()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("({[]})"));
            Assert.IsTrue(ParenthesisChecker.IsBalanced("{[()]}"));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("{[(])}"));
        }

        [TestMethod]
        public void TestBalancedAndUnbalancedScenarios()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("()[]{}"));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("([)]"));
            Assert.IsFalse(ParenthesisChecker.IsBalanced("{[}"));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced(""));
        }

        [TestMethod]
        public void TestStringWithoutParentheses()
        {
            Assert.IsTrue(ParenthesisChecker.IsBalanced("abc"));
        }
    }
}
