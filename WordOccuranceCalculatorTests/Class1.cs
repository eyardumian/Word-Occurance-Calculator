using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurrenceCalculatorTests
{
    [TestFixture]
    public class WordOccurencesTests
    {
        [Test]
        public void WordCalculatorTest()
        {
            //Arrange
            var input = "hi you how you";
            var expectedOutput = "hi, 1"
                + "\r\n" + "you, 2" + "\r\n" + "how, 1" + "\r\n"
                + "you, 2";

            //Act
            var actualOutput = WordCalculator.CalculateOccurrences(input);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput, "Invalid value returned");
        }

        private object CalculateOccurrences(string input)
        {
            throw new NotImplementedException();
        }
    }
}
