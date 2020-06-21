using System;
using Xunit;
using Moq;
using BerlinClock.Service;

namespace BerlinClock.Tests
{
    public class BerlinClockParserTest
    {
        [Theory]
        [InlineData("13:17:02", "Y\nRROO\nRRRO\nYOOOOOOOOOO\nYYOO")]
        [InlineData("02:10:17", "O\nOOOO\nRROO\nYYOOOOOOOOO\nOOOO")]
        [InlineData("23:59:02", "Y\nRRRR\nRRRO\nYYRYYRYYRYY\nYYYY")]
        [InlineData("00:00:33", "O\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO")]
        [InlineData("16:34:59", "O\nRRRO\nROOO\nYYRYYROOOOO\nYYYY")]
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
