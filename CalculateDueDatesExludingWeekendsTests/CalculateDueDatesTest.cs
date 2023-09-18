using CalculateDueDatesExludingWeekends;

namespace CalculateDueDatesExludingWeekendsTests
{
    public class CalculateDueDatesTest
    {
        private CalculateDueDatesHelper _sutHelper;

        public CalculateDueDatesTest()
        {
            _sutHelper = new CalculateDueDatesHelper();
        }

        [Fact]
        public void ShouldVerifyHighPriorityNextDay()
        {
            //arrange
            string priority = "1 day";
            DateTime today = new DateTime(2023, 9, 18);
            DateTime resultDate;

            //act
            resultDate = _sutHelper.RecalculateDueDate(priority, today);

            //assert
            Assert.Equal(resultDate, new DateTime(2023, 9, 19));
        }

        [Fact]
        public void ShouldVerifyAveragePriorityTwoDaysAfter()
        {
            //arrange
            string priority = "2 day";
            DateTime today = new DateTime(2023, 9, 18);
            DateTime resultDate;

            //act
            resultDate = _sutHelper.RecalculateDueDate(priority, today);

            //assert
            Assert.Equal(resultDate, new DateTime(2023, 9, 20));
        }

        [Fact]
        public void ShouldVerifyLowPriorityFiveDaysAfter()
        {
            //arrange
            string priority = "5 days";
            DateTime today = new DateTime(2023, 9, 18);
            DateTime resultDate;

            //act
            resultDate = _sutHelper.RecalculateDueDate(priority, today);

            //assert
            Assert.Equal(resultDate, new DateTime(2023, 9, 25));
        }
    }
}