using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestareTemaCalculator;

namespace TesteCalculatorAritmetic
{
    [TestClass]
    public class InmultireTest
    {
        [DataTestMethod]
        [DataRow(2, -4, -8)]
        [DataRow(7.25, 10, 72.5)]
        [DataRow(0, 0, 0)]
        public void InmultireaPositiveCases(double a, double b, double sum)
        {
            double result = Program.Inmultire(a, b);
            Assert.AreEqual(sum, result);
        }

        [DataTestMethod]
        [DataRow(2, 4, 20)]
        [DataRow(7.25, 10, 1725)]
        [DataRow(0, 0, 1)]
        public void InmultireaNegativeCases(double a, double b, double sum)
        {
            double result = Program.Inmultire(a, b);
            Assert.AreNotEqual(sum, result);
        }
    }
}
