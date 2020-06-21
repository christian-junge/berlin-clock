using System;
using Xunit;
using BerlinClock.Service;

namespace BerlinClock.Tests
{
    public class TimeParserTest
    {
        private readonly ITimeParser timeParser;

        public TimeParserTest() {
            timeParser = new TimeParser();
        }

        [Theory]
        [InlineData("25:17:02")]
        [InlineData("22:76:21")]
        [InlineData("03:04:66")]
        [InlineData("3:4:6")]
        [InlineData("some other invalid input")]
        public void ShouldThrowException(string input)
        {
            Assert.Throws<FormatException>(() => timeParser.ParseTimeString(input));
        }

        [Theory]
        [InlineData("13:17:02", 13, 17, 2)]
        [InlineData("22:22:21", 22, 22, 21)]
        [InlineData("03:04:05", 3, 4, 5)]
        public void ShouldReturnTimeSpan(string input, int hours, int minutes, int seconds)
        {
            timeParser.ParseTimeString(input);
        }
    }
}
