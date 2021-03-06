﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculadora
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void CanSummTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Sumar(value1, value2);

            Assert.Equal(expected, result);
        }

    }
}
