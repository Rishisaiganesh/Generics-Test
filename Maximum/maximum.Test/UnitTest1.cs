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
        [Test]
        public void As_Given_FloatfirsttNumber_Return_sameNumber()
        {
            Check maximum = new Check();
            ///Arrange
            float firstNumber = 30.2f;
            float secondNumber = 20.2f;
            float thirdNumber = 10.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_FloatsecondNumber_Return_sameNumber()
        {
             Check maximum = new Check();
            ///Arrange
            float firstNumber = 20.2f;
            float secondNumber = 30.2f;
            float thirdNumber = 10.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_FloatthirdNumber_Return_sameNumber()
        {
            Check maximum = new Check();
            ///Arrange
            float firstNumber = 20.2f;
            float secondNumber = 10.2f;
            float thirdNumber = 30.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }

    }
}
