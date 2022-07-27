using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestareTemaCalculator;

namespace TesteCalculatorAritmetic
{
    [TestClass]
    public class DiferentaTest
    {
        [DataTestMethod]
        [DataRow(2, -4, 6)]
        [DataRow(7.25, 10, -2.75)]
        [DataRow(0, 0, 0)]
        public void DiferentaPositiveCases(double a, double b, double sum)
        {
            double result = Program.Diferenta(a, b);
            Assert.AreEqual(sum, result);
        }

        [DataTestMethod]
        [DataRow(2, -4, 2)]
        [DataRow(7.25, 10, 2.75)]
        [DataRow(0, 0, 1)]
        public void DiferentaNegativeCases(double a, double b, double sum)
        {
            double result = Program.Diferenta(a, b);
            Assert.AreNotEqual(sum, result);
        }
    }
}
