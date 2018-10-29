using System;
using TechTalk.SpecFlow;
using Ejemplo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.FirstNumber = 40;
            calculator.SecondNumber = 80;
            result = calculator.Add();
            Assert.AreEqual(120, result);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }


        [Then(@"the resultMultiplicacion")]
        public int Return_mutipli_dos_numeros(int n, int n2)
        {
            calculator.FirstNumber = n;
            calculator.SecondNumber = n2;
            result = calculator.Multi();
            return result;
        }


        [Then(@"the resultDivision")]
        public int Return_division_dos_numeros(int n, int n2)
        {
            result = calculator.Division(n, n2);
            return result;
        }

        [Then(@"the resultResta")]
        public int Return_resta_dos_numeros(int n, int n2)
        {
            result = calculator.Resta(n, n2);
            return result;
        }

    }
}
