using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
           Boolean result = BalancedBrackets.HasBalancedBrackets("");
           Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void FullyWrappedBalancedStringReturnsTrue()
        {
            String input = "[LaunchCode]";
            Boolean result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void PartiallyWrappedBalancedStringReturnsTrue()
        {
            String input = "Launch[Code]";
            Boolean result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void FullyWrappedBalancedStringReturnsFalse()
        {
            String input = "[LaunchCode";
            Boolean result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void PartiallyWrappedBalancedStringReturnsFalse()
        {
            String input = "Launch[Code";
            Boolean result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void WrongNestedBracketReturnsFalse()
        {
            String input = "][";
            Boolean result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }
    }
}
