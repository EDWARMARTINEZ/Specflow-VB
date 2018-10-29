using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var calculator = new CalculatorSteps();
            calculator.WhenIPressAdd();
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            var calculator = new CalculatorSteps();
            var resultado = calculator.Return_mutipli_dos_numeros(2, 4);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            var calculator = new CalculatorSteps();
            var resultado = calculator.Return_division_dos_numeros(12, 3);
            Assert.AreEqual(4, resultado);
        }


        [TestMethod]
        public void TestResta()
        {
            var calculator = new CalculatorSteps();
            var resultado = calculator.Return_resta_dos_numeros(15, 5);
            Assert.AreEqual(10, resultado);
        }

    }
}
