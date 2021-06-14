using Maximum;
using NUnit.Framework;

namespace maximum.Test
{
    public class Tests
    {
        [Test]
        public void FirstNumber()
        {
            Check max = new Check();
            ///Arrange
            int firstNumber = 30;
            int secondNumber = 20;
            int thirdNumber = 10;
            int expected = 30;
            ////Act
            int result = max.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SecondNumber()
        {
            Check maximum = new Check();
            ///Arrange
            int firstNumber = 20;
            int secondNumber = 30;
            int thirdNumber = 10;
            int expected = 30;
            ////Act
            int result = maximum.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ThirdNumber()
        {
            Check maximum = new Check();
            ///Arrande
            int firstNumber = 20;
            int secondNumber = 10;
            int thirdNumber = 30;
            int expected = 30;
            ///Act
            int result = maximum.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }

    }
}
