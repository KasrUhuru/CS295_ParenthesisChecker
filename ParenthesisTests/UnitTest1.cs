using System;
using Xunit;
using ParenthesisChecker;

namespace ParenthesisChecker
{
    public class ParenthesisCheckerTests
    {
        [Fact]
        public void TestSingleTypeBrackets()
        {
            Assert.True(ParenthesisChecker.IsBalanced("()"));
            Assert.True(ParenthesisChecker.IsBalanced("[]"));
            Assert.True(ParenthesisChecker.IsBalanced("{}"));
        }

        [Fact]
        public void TestMixedTypeBrackets()
        {
            Assert.True(ParenthesisChecker.IsBalanced("({[]})"));
            Assert.True(ParenthesisChecker.IsBalanced("{[()]}"));
            Assert.False(ParenthesisChecker.IsBalanced("{[(])}"));
        }

        [Fact]
        public void TestBalancedAndUnbalancedScenarios()
        {
            Assert.True(ParenthesisChecker.IsBalanced("()[]{}"));
            Assert.False(ParenthesisChecker.IsBalanced("([)]"));
            Assert.False(ParenthesisChecker.IsBalanced("{[}"));
        }

        [Fact]
        public void TestEmptyString()
        {
            Assert.True(ParenthesisChecker.IsBalanced(""));
        }

        [Fact]
        public void TestStringWithoutParentheses()
        {
            Assert.True(ParenthesisChecker.IsBalanced("abc"));
        }
    }
}
