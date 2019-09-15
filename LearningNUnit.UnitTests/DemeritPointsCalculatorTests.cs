
using System;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningNUnit.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsLessThan0OrGreaterThanMaxSpeed_ReturnArgumentOutOfRangeException(int speed)
        {
            var demeritCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(30, 0)]
        [TestCase(65, 0)]
        [TestCase(70, 1)]
        [TestCase(100, 7)]        
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int demeritPoint)
        {
            var demeritCalculator = new DemeritPointsCalculator();
            var result = demeritCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(demeritPoint));
        }
    }
}
