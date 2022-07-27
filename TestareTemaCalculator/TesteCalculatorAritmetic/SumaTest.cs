using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestareTemaCalculator;

namespace TesteCalculatorAritmetic
{
    [TestClass]
    public class SumaTest
    {
        [DataTestMethod]
        [DataRow(2, 4, 6)]
        [DataRow(7.25, 10, 17.25)]
        [DataRow(0, 0, 0)]
        public void SumaPositiveCases(double a, double b, double sum)
        {
            double result = Program.Suma(a, b);
            Assert.AreEqual(sum, result);
        }

        [DataTestMethod]
        [DataRow(2, 4, 20)]
        [DataRow(7.25, 10, 1725)]
        [DataRow(0, 0, 1)]
        public void SumaNegativeCases(double a, double b, double sum)
        {
            double result = Program.Suma(a, b);
            Assert.AreNotEqual(sum, result);
        }
    }
}
