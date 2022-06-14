using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        

        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            Calculator calculator = new Calculator();
            double expected = 5;
            double actual = calculator.Add(3, 2);
            Assert.Equal(expected, actual);
        }
    }
}
