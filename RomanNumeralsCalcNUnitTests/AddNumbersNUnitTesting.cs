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
    public class AddNumbersNUnitTesting
    {
        [Test]
        [TestCase(10,2, ExpectedResult = "XII")]
        [TestCase(50,9, ExpectedResult = "LIX")]
        [TestCase(100,8, ExpectedResult = "CVIII")]
        [TestCase(500,12, ExpectedResult = "DXII")]
        [TestCase(1000,24, ExpectedResult = "MXXIV")]
       
        public string GivenInteger_WhenConvertedToRomanNumeral_AssertThatAsExpectedResult(int value1,int value2)
        {
            //Arrange
            string romanNumeral;
            //Act
            romanNumeral = AddNumbers.GenerateRomanNumerals(value1,value2);
            //Assert
            return romanNumeral;
        }

    }
}
