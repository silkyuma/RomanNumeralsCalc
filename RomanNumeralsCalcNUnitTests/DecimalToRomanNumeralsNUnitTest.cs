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
    public class DecimalToRomanNumeralsNUnitTest
    {
        [Test]
        public void GivenInteger1_WhenConvertedToRomanNumeral_AssertThatItsI()
        {
            //Arrange
            string romanNumeral;
            //Act
            romanNumeral = NumberToRomanNumeralsCalculator.CalculateRomanNumeral(1);
            //Assert
            Assert.AreEqual(romanNumeral, "I");
        }
        [Test]
        public void GivenInteger5_WhenConvertedToRomanNumeral_AssertThatItsV()
        {
            //Arrange
            string romanNumeral;
            //Act
            romanNumeral = NumberToRomanNumeralsCalculator.CalculateRomanNumeral(5);
            //Assert
            Assert.AreEqual(romanNumeral, "V");
        }
        [Test]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(500, ExpectedResult = "D")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(900, ExpectedResult = "CM")]
        [TestCase(90, ExpectedResult = "XC")]
        [TestCase(9, ExpectedResult = "IX")]
        public string GivenInteger_WhenConvertedToRomanNumeral_AssertThatAsExpectedResult(int value)
        {
            //Arrange
            string romanNumeral;
            //Act
            romanNumeral = NumberToRomanNumeralsCalculator.CalculateRomanNumeral(value);
            //Assert
            return romanNumeral;
        }
    }
}
