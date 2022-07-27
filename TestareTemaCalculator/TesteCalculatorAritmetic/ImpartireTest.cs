using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestareTemaCalculator;

namespace TesteCalculatorAritmetic
{
    [TestClass]
    public class ImpartireTest
    {
        [DataTestMethod]
        [DataRow(2, -4, "-0.5")]
        [DataRow(7.25, 10, "0.725")]
        [DataRow(0, 1, "0")]
        public void ImpartirePositiveCases(double a, double b, string sum)
        {
            string result = Program.Impartire(a, b);
            Assert.AreEqual(sum, result);
        }

        [DataTestMethod]
        [DataRow(2, 4, "20")]
        [DataRow(7.25, 10, "1725")]
        [DataRow(0, 1, "2")]
        public void ImpartireNegativeCases(double a, double b, string sum)
        {
            string result = Program.Impartire(a, b);
            Assert.AreNotEqual(sum, result);
        }

        [TestMethod]
        public void ImpartireHandleZeroDivisionPositiveCase()
        {
            Assert.AreEqual("Impartirea la 0 nu se poate", Program.Impartire(20, 0));
        }
        [TestMethod]
        public void ImpartireHandleZeroDivisionNegativeCase()
        {
            Assert.AreNotEqual("20", Program.Impartire(20, 0));
        }
    }
}
