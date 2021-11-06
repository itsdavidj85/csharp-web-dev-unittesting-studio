using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void OnlyBracketsWithPretextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[]"));
        }
        [TestMethod]
        public void OnlyBracketsWithSubtextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]abc"));
        }
        // Only one open bracket
        [TestMethod]
        public void OneOpenBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        // Only one closed bracket
        [TestMethod]
        public void OneClosedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        // Only one open bracket - with subtext
        [TestMethod]
        public void OneOpenBracketsWithSubtextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("abc["));
        }
        // Only one closed bracket - with pretext
        [TestMethod]
        public void OneClosedBracketsWithSubtextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]abc"));
        }
        // > 1 open no closed
        [TestMethod]
        public void GreaterThanOneOpenBracketNoClosedReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("abc[["));
        }
        // > 1 open 1 closed
        // > 1 closed no open
        // > 1 closed 1 open
        // Only one open bracket - with subtext
        // Only one closed bracket - with subtext
        // > 1 open no closed - with subtext
        // > 1 open 1 closed - with subtext
        // > 1 closed no open - with subtext
        // > 1 closed 1 open - with subtext
        // Only one open bracket - with pretext
        // Only one closed bracket - with pretext
        // > 1 open no closed - with with pretext
        // > 1 open 1 closed - with with pretext
        // > 1 closed no open - with with pretext
        // > 1 closed 1 open - with with pretext
    }
}
