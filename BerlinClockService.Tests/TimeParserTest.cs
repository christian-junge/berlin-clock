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

        [Fact]
        public void ShouldThrowException()
        {
            throw new NotImplementedException();
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
