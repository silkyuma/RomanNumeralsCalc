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
    public class ValidationInputNUnitTest
    {
        [Test]
        [TestCase(23)]
        [TestCase(55)]
        [TestCase(909)]
        [TestCase(1234)]
        [TestCase(456)]
        public void IsValueValidReturnTrue(int value)
        {
            //Arrange
            bool flag;
            //Act
            flag = ValidateInput.IsInputValid(value);
            //Assert
            Assert.IsTrue(flag);
        }
        [Test]
        [TestCase(0)]
        [TestCase(4000)]
        [TestCase(4034)]
        [TestCase(9003)]

        public void IsValueValidReturnFalse(int value)
        {
            //Arrange
            bool flag;
            //Act
            flag = ValidateInput.IsInputValid(value);
            //Assert
            Assert.IsFalse(flag);
        }
    }
}
