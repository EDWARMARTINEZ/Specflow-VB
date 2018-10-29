using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejemplo
{
    [TestClass]
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        public int Add()
        {
            return FirstNumber + SecondNumber;
        }


        public int Multi()
        {
            return FirstNumber * SecondNumber;
        }


        public int Division(int n, int n2)
        {
            FirstNumber = n;
            SecondNumber = n2;
            return FirstNumber / SecondNumber;
        }

        public int Resta(int n, int n2)
        {
            FirstNumber = n;
            SecondNumber = n2;
            return FirstNumber - SecondNumber;
        }
    }
   
}
