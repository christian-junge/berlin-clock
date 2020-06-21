using System;
using Xunit;
using Moq;
using BerlinClock.Service;

namespace BerlinClock.Tests
{
    public class BerlinClockParserTest
    {
        [Theory]
        [InlineData("13:17:02", "xxx")]
        public void ShouldReturnString(string input, string output)
        {
            Mock<ITimeParser> timeParserMock = new Mock<ITimeParser>();
            timeParserMock.Setup(mock => mock.ParseTimeString(input)).Returns(TimeSpan.Parse(input));

            IBerlinClockParser parser = new BerlinClockParser(timeParserMock.Object);

            string actual = parser.getBerlinTime(input);

            Assert.Equal(output, actual);
        }
    }
}
