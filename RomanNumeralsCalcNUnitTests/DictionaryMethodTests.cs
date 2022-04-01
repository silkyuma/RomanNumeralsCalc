using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;


namespace RomanNumeralsCalc
{
    [TestFixture]
    public class DictionaryMethodTests
    {
        [Test]
        public void GivenValueCheckingIfDictionaryContains5()
        {
            //Arrange
            OrderedDictionary dict = new OrderedDictionary();

            //Act
            dict = new OrderedDictionary() { { 'V', 5 }, { 'X', 10 }, { 'L', 50 } };
            //Assert

            Assert.IsTrue(dict.ContainsValue(5));
        }
        [Test]
        public void GivenValue_WhenCheckingIfDictionaryContainsIt_AssertThatItDoesNotExists()
        {
            //Arrange
            OrderedDictionary dict = new OrderedDictionary();
            //Act
            dict = new OrderedDictionary() { { 'V', 5 }, { 'X', 10 }, { 'L', 50 } };
            //Assert
            Assert.IsFalse(dict.ContainsValue(52));
        }
    }
}
