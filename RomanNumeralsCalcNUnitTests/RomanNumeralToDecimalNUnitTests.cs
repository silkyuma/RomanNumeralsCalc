using NUnit.Framework;
using RomanNumeralsCalc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc
{
    [TestFixture]
    public class RomanNumeralToDecimalNUnitTests
    {
        [Test]
        [TestCase("X", ExpectedResult=10)]
        [TestCase("L", ExpectedResult = 50)]
        [TestCase("C", ExpectedResult = 100)]
        [TestCase("D", ExpectedResult = 500)]
        [TestCase("V", ExpectedResult = 5)]
        [TestCase("M", ExpectedResult = 1000)]
        [TestCase("IX", ExpectedResult = 9)]
        [TestCase("MMMDCCXXIV", ExpectedResult = 3724)]
        [TestCase("MMMDXXIV", ExpectedResult = 3524)]
        [TestCase("MMMDXXX", ExpectedResult = 3530)]

        public int GivenNumeral_WhenConvertedDecimal_AssertThatAsExpectedResult(string value)
        {
            //Arrange
            int decValue;
            //Act
            decValue = RomanNumeralsToNumberCalculator.RomanToDecimal(value);
            //Assert
            return decValue;
        }

    }
}
