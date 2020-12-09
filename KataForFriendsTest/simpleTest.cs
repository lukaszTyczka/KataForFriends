using FluentAssertions;
using KataForFirends;
using NUnit.Framework;
using System;

namespace KataForFriendsTest
{
    /// <summary>
    /// Odpalanie testow. U gory wejdz w Test > test explorer i test explorerze nacisnij run all tests :)
    /// </summary>
    [TestFixture]
    public class simpleTest
    {
        [Test]
        public void TestTest()
        {
            new simple().Test().Should().BeTrue();
        }

        [Test]
        public void ThrowExceptionTest()
        {
            var simple = new simple();

            Action act = () => simple.ThrowExcpetion();

            act.Should().Throw<Exception>();
        }
        
        [TestCase(2D,2D,1D, TestName = "Divaded: 2/2 = 1")]
        [TestCase(4D,2D,2D, TestName = "Divaded: 4/2 = 2")]
        [TestCase(16D, 2D, 8D, TestName = "Divaded: 16/2 = 8")]
        [TestCase(16D, 4D, 4D, TestName = "Divaded: 16/4 = 4")]
        [TestCase(2940D, 84D, 35D, TestName = "Divaded: 2940/84 = 35")]
        [TestCase(250D, 5D, 50D, TestName = "Divaded: 250/5 = 50")]
        public void DivadedShouldReturnProperValue(double number1, double numer2, double result)
        {
            var simple = new simple();

            var calculatedResult = simple.Divaded(number1, numer2);

            calculatedResult.Should().Be(result);
        }

        [Test]
        public void DivadedShouldReturnArgumentExceptionWhenSecondNumberIsZero()
        {
            var simple = new simple();

            Action calculateAct = () => simple.Divaded(2, 0);

            calculateAct.Should().Throw<ArgumentException>();
        }

        [TestCase(2020,10,10, 2020,10,1, 9, TestName = "CalulateDays Data1:2020-10-10 Data2:2020-10-01 Wynik: 9")]
        [TestCase(2020,10,1, 2020,10,10, 9, TestName = "CalulateDays Data1:2020-10-1 Data2:2020-10-10 Wynik: 9")]
        [TestCase(2021, 4, 3, 2017, 2, 5, 1518, TestName = "CalulateDays Data1:2021-04-03 Data2:2020-02-05 Wynik: 1518")]
        [TestCase(1978, 6, 6, 2020, 10, 10, 15467, TestName = "CalulateDays Data1:1978-06-06 Data2:2020-10-10 Wynik: 15467")]
        public void CalulateDaysShouldReturnDaysBeetwenTwoDates(int year1, int month1, int day1, int year2, int month2, int day2,int result)
        {
            var date1 = new DateTime(year1, month1, day1);
            var date2 = new DateTime(year2, month2, day2);
            var simple = new simple();

            var calculateResult = simple.CalculateDays(date1, date2);

            calculateResult.Should().Be(result);

        }
        [TestCase(new double[0], 0D,TestName = "SumNumbers: [] result 0")]
        [TestCase(new[] { 1, 2.5 }, 3.5,TestName = "SumNumbers: [1, 2,5] result 3,5")]
        [TestCase(new[] { 1, -2.5, 5.0, 3.1 }, 6.6,TestName = "SumNumbers: [1, -2,5, 5,0, 3,1 ] result 6,6")]
        [TestCase(new[] { 1, -2.5, 5.0, 3.1, -6.6 }, 0,TestName = "SumNumbers: [1, -2,5, 5,0, 3,1, -6,6 ] result 0")]
        public void SumNumbersShouldReturnSum(double[] numbers, double result)
        {
            var simple = new simple();

            var calculatedResult = simple.SumNumbers(numbers);

            calculatedResult.Should().Be(result);
        }
    }
}
