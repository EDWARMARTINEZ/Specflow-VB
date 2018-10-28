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
    }
   
}
