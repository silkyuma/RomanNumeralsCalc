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
    public class PowerCalcNUnitTests
    {
        [Test]
        public void IsValuePowerOfTenInput200ReturnFalse()
        {
            //arrange
            bool flag;
            //Act
            flag = PowerCalculator.IsValuePowerOfTen(200);
            //Assert
            Assert.IsFalse(flag);
        }

        [Test]
        public void IsValuePowerOfTenInput1000ReturnTrue()
        {
            //arrange
            bool flag;
            //Act
            flag = PowerCalculator.IsValuePowerOfTen(1000);
            //Assert
            Assert.IsTrue(flag);
        }
    }
}
