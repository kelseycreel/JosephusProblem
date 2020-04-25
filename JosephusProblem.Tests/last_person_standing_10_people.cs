using System;
using Xunit;

namespace JosephusProblem.Tests
{
    public class last_person_standing_10_people
    {
        [Fact]
        public void numberOfPeople10()
        {
            var numberOfPeople = 10;
            var killingInterval = 3;

            var expectedResult = 4;

            var lastPersonStanding = new JosephusProblem();

            var actualResult = lastPersonStanding.LastPersonStanding(numberOfPeople, killingInterval);

            Assert.Equal(actualResult, expectedResult);
        }
    }
}
